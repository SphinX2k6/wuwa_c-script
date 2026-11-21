using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001004 RID: 4100
	public sealed class RogueRoomInfo : IMessage<RogueRoomInfo>, IMessage, IEquatable<RogueRoomInfo>, IDeepCloneable<RogueRoomInfo>, IBufferMessage
	{
		// Token: 0x06015F38 RID: 89912 RVA: 0x0033192A File Offset: 0x0032FB2A
		[NullableContext(1)]
		public static RogueRoomInfo Create()
		{
			return new RogueRoomInfo();
		}

		// Token: 0x17004965 RID: 18789
		// (get) Token: 0x06015F39 RID: 89913 RVA: 0x00331931 File Offset: 0x0032FB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004966 RID: 18790
		// (get) Token: 0x06015F3A RID: 89914 RVA: 0x00331934 File Offset: 0x0032FB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueRoomInfo.Descriptor;
			}
		}

		// Token: 0x06015F3B RID: 89915 RVA: 0x0033193B File Offset: 0x0032FB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoomInfo()
		{
		}

		// Token: 0x06015F3C RID: 89916 RVA: 0x0033194E File Offset: 0x0032FB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoomInfo(RogueRoomInfo other) : this()
		{
			this.rogueRoomDict_ = other.rogueRoomDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F3D RID: 89917 RVA: 0x00331978 File Offset: 0x0032FB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoomInfo Clone()
		{
			return new RogueRoomInfo(this);
		}

		// Token: 0x17004967 RID: 18791
		// (get) Token: 0x06015F3E RID: 89918 RVA: 0x00331980 File Offset: 0x0032FB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> RogueRoomDict
		{
			get
			{
				return this.rogueRoomDict_;
			}
		}

		// Token: 0x06015F3F RID: 89919 RVA: 0x00331988 File Offset: 0x0032FB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueRoomInfo);
		}

		// Token: 0x06015F40 RID: 89920 RVA: 0x00331996 File Offset: 0x0032FB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueRoomInfo other)
		{
			return other != null && (other == this || (this.RogueRoomDict.Equals(other.RogueRoomDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F41 RID: 89921 RVA: 0x003319CC File Offset: 0x0032FBCC
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

		// Token: 0x06015F42 RID: 89922 RVA: 0x00331A00 File Offset: 0x0032FC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F43 RID: 89923 RVA: 0x00331A0D File Offset: 0x0032FC0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F44 RID: 89924 RVA: 0x00331A16 File Offset: 0x0032FC16
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

		// Token: 0x06015F45 RID: 89925 RVA: 0x00331A40 File Offset: 0x0032FC40
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

		// Token: 0x06015F46 RID: 89926 RVA: 0x00331A79 File Offset: 0x0032FC79
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

		// Token: 0x06015F47 RID: 89927 RVA: 0x00331AA7 File Offset: 0x0032FCA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F48 RID: 89928 RVA: 0x00331AB0 File Offset: 0x0032FCB0
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

		// Token: 0x04008427 RID: 33831
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008428 RID: 33832
		public const int RogueRoomDictFieldNumber = 1;

		// Token: 0x04008429 RID: 33833
		private static readonly MapField<string, int>.Codec _map_rogueRoomDict_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x0400842A RID: 33834
		private readonly MapField<string, int> rogueRoomDict_ = new MapField<string, int>();
	}
}
