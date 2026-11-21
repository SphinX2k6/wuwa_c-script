using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112B RID: 4395
	public sealed class RoverRogueBlessGroupData : IMessage<RoverRogueBlessGroupData>, IMessage, IEquatable<RoverRogueBlessGroupData>, IDeepCloneable<RoverRogueBlessGroupData>, IBufferMessage
	{
		// Token: 0x060177B3 RID: 96179 RVA: 0x0036A9B7 File Offset: 0x00368BB7
		[NullableContext(1)]
		public static RoverRogueBlessGroupData Create()
		{
			return new RoverRogueBlessGroupData();
		}

		// Token: 0x17004EEA RID: 20202
		// (get) Token: 0x060177B4 RID: 96180 RVA: 0x0036A9BE File Offset: 0x00368BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueBlessGroupData> Parser
		{
			get
			{
				return RoverRogueBlessGroupData._parser;
			}
		}

		// Token: 0x17004EEB RID: 20203
		// (get) Token: 0x060177B5 RID: 96181 RVA: 0x0036A9C5 File Offset: 0x00368BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EEC RID: 20204
		// (get) Token: 0x060177B6 RID: 96182 RVA: 0x0036A9C8 File Offset: 0x00368BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueBlessGroupData.Descriptor;
			}
		}

		// Token: 0x060177B7 RID: 96183 RVA: 0x0036A9CF File Offset: 0x00368BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupData()
		{
		}

		// Token: 0x060177B8 RID: 96184 RVA: 0x0036A9E2 File Offset: 0x00368BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupData(RoverRogueBlessGroupData other) : this()
		{
			this.blessGroupId_ = other.blessGroupId_;
			this.blessIdList_ = other.blessIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060177B9 RID: 96185 RVA: 0x0036AA18 File Offset: 0x00368C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupData Clone()
		{
			return new RoverRogueBlessGroupData(this);
		}

		// Token: 0x17004EED RID: 20205
		// (get) Token: 0x060177BA RID: 96186 RVA: 0x0036AA20 File Offset: 0x00368C20
		// (set) Token: 0x060177BB RID: 96187 RVA: 0x0036AA28 File Offset: 0x00368C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BlessGroupId
		{
			get
			{
				return this.blessGroupId_;
			}
			set
			{
				this.blessGroupId_ = value;
			}
		}

		// Token: 0x17004EEE RID: 20206
		// (get) Token: 0x060177BC RID: 96188 RVA: 0x0036AA31 File Offset: 0x00368C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BlessIdList
		{
			get
			{
				return this.blessIdList_;
			}
		}

		// Token: 0x060177BD RID: 96189 RVA: 0x0036AA39 File Offset: 0x00368C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueBlessGroupData);
		}

		// Token: 0x060177BE RID: 96190 RVA: 0x0036AA48 File Offset: 0x00368C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueBlessGroupData other)
		{
			return other != null && (other == this || (this.BlessGroupId == other.BlessGroupId && this.blessIdList_.Equals(other.blessIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060177BF RID: 96191 RVA: 0x0036AA98 File Offset: 0x00368C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BlessGroupId != 0)
			{
				num ^= this.BlessGroupId.GetHashCode();
			}
			num ^= this.blessIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060177C0 RID: 96192 RVA: 0x0036AAE5 File Offset: 0x00368CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060177C1 RID: 96193 RVA: 0x0036AAF2 File Offset: 0x00368CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060177C2 RID: 96194 RVA: 0x0036AAFC File Offset: 0x00368CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BlessGroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BlessGroupId);
			}
			this.blessIdList_.WriteTo(ref output, RoverRogueBlessGroupData._repeated_blessIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060177C3 RID: 96195 RVA: 0x0036AB4C File Offset: 0x00368D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BlessGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BlessGroupId);
			}
			num += this.blessIdList_.CalculateSize(RoverRogueBlessGroupData._repeated_blessIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060177C4 RID: 96196 RVA: 0x0036ABA0 File Offset: 0x00368DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueBlessGroupData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BlessGroupId != 0)
			{
				this.BlessGroupId = other.BlessGroupId;
			}
			this.blessIdList_.Add(other.blessIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060177C5 RID: 96197 RVA: 0x0036ABED File Offset: 0x00368DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060177C6 RID: 96198 RVA: 0x0036ABF8 File Offset: 0x00368DF8
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
				if (num != 16U)
				{
					if (num != 24U && num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.blessIdList_.AddEntriesFrom(ref input, RoverRogueBlessGroupData._repeated_blessIdList_codec);
					}
				}
				else
				{
					this.BlessGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008C2D RID: 35885
		private static readonly MessageParser<RoverRogueBlessGroupData> _parser = new MessageParser<RoverRogueBlessGroupData>(() => new RoverRogueBlessGroupData());

		// Token: 0x04008C2E RID: 35886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C2F RID: 35887
		public const int BlessGroupIdFieldNumber = 2;

		// Token: 0x04008C30 RID: 35888
		private int blessGroupId_;

		// Token: 0x04008C31 RID: 35889
		public const int BlessIdListFieldNumber = 3;

		// Token: 0x04008C32 RID: 35890
		private static readonly FieldCodec<int> _repeated_blessIdList_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008C33 RID: 35891
		private readonly RepeatedField<int> blessIdList_ = new RepeatedField<int>();
	}
}
