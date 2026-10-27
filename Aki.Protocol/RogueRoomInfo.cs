using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001014 RID: 4116
	public sealed class RogueRoomInfo : IMessage<RogueRoomInfo>, IMessage, IEquatable<RogueRoomInfo>, IDeepCloneable<RogueRoomInfo>, IBufferMessage
	{
		// Token: 0x0601601D RID: 90141 RVA: 0x00332FE6 File Offset: 0x003311E6
		[NullableContext(1)]
		public static RogueRoomInfo Create()
		{
			return new RogueRoomInfo();
		}

		// Token: 0x1700498F RID: 18831
		// (get) Token: 0x0601601E RID: 90142 RVA: 0x00332FED File Offset: 0x003311ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004990 RID: 18832
		// (get) Token: 0x0601601F RID: 90143 RVA: 0x00332FF0 File Offset: 0x003311F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueRoomInfo.Descriptor;
			}
		}

		// Token: 0x06016020 RID: 90144 RVA: 0x00332FF7 File Offset: 0x003311F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoomInfo()
		{
		}

		// Token: 0x06016021 RID: 90145 RVA: 0x0033300A File Offset: 0x0033120A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoomInfo(RogueRoomInfo other) : this()
		{
			this.rogueRoomDict_ = other.rogueRoomDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016022 RID: 90146 RVA: 0x00333034 File Offset: 0x00331234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoomInfo Clone()
		{
			return new RogueRoomInfo(this);
		}

		// Token: 0x17004991 RID: 18833
		// (get) Token: 0x06016023 RID: 90147 RVA: 0x0033303C File Offset: 0x0033123C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> RogueRoomDict
		{
			get
			{
				return this.rogueRoomDict_;
			}
		}

		// Token: 0x06016024 RID: 90148 RVA: 0x00333044 File Offset: 0x00331244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueRoomInfo);
		}

		// Token: 0x06016025 RID: 90149 RVA: 0x00333052 File Offset: 0x00331252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueRoomInfo other)
		{
			return other != null && (other == this || (this.RogueRoomDict.Equals(other.RogueRoomDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016026 RID: 90150 RVA: 0x00333088 File Offset: 0x00331288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.RogueRoomDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016027 RID: 90151 RVA: 0x003330BC File Offset: 0x003312BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016028 RID: 90152 RVA: 0x003330C9 File Offset: 0x003312C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016029 RID: 90153 RVA: 0x003330D2 File Offset: 0x003312D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueRoomDict_.WriteTo(ref output, RogueRoomInfo._map_rogueRoomDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601602A RID: 90154 RVA: 0x003330FC File Offset: 0x003312FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueRoomDict_.CalculateSize(RogueRoomInfo._map_rogueRoomDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601602B RID: 90155 RVA: 0x00333135 File Offset: 0x00331335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueRoomInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueRoomDict_.MergeFrom(other.rogueRoomDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601602C RID: 90156 RVA: 0x00333163 File Offset: 0x00331363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601602D RID: 90157 RVA: 0x0033316C File Offset: 0x0033136C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueRoomDict_.AddEntriesFrom(ref input, RogueRoomInfo._map_rogueRoomDict_codec);
				}
			}
		}

		// Token: 0x040083FD RID: 33789
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083FE RID: 33790
		public const int RogueRoomDictFieldNumber = 1;

		// Token: 0x040083FF RID: 33791
		private static readonly MapField<string, int>.Codec _map_rogueRoomDict_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04008400 RID: 33792
		private readonly MapField<string, int> rogueRoomDict_ = new MapField<string, int>();
	}
}
