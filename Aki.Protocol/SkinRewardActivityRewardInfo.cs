using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001243 RID: 4675
	public sealed class SkinRewardActivityRewardInfo : IMessage<SkinRewardActivityRewardInfo>, IMessage, IEquatable<SkinRewardActivityRewardInfo>, IDeepCloneable<SkinRewardActivityRewardInfo>, IBufferMessage
	{
		// Token: 0x06018EA3 RID: 102051 RVA: 0x003A03E1 File Offset: 0x0039E5E1
		[NullableContext(1)]
		public static SkinRewardActivityRewardInfo Create()
		{
			return new SkinRewardActivityRewardInfo();
		}

		// Token: 0x17005406 RID: 21510
		// (get) Token: 0x06018EA4 RID: 102052 RVA: 0x003A03E8 File Offset: 0x0039E5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkinRewardActivityRewardInfo> Parser
		{
			get
			{
				return SkinRewardActivityRewardInfo._parser;
			}
		}

		// Token: 0x17005407 RID: 21511
		// (get) Token: 0x06018EA5 RID: 102053 RVA: 0x003A03EF File Offset: 0x0039E5EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005408 RID: 21512
		// (get) Token: 0x06018EA6 RID: 102054 RVA: 0x003A03F2 File Offset: 0x0039E5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinRewardActivityRewardInfo.Descriptor;
			}
		}

		// Token: 0x06018EA7 RID: 102055 RVA: 0x003A03F9 File Offset: 0x0039E5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityRewardInfo()
		{
		}

		// Token: 0x06018EA8 RID: 102056 RVA: 0x003A0401 File Offset: 0x0039E601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityRewardInfo(SkinRewardActivityRewardInfo other) : this()
		{
			this.configId_ = other.configId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018EA9 RID: 102057 RVA: 0x003A0432 File Offset: 0x0039E632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityRewardInfo Clone()
		{
			return new SkinRewardActivityRewardInfo(this);
		}

		// Token: 0x17005409 RID: 21513
		// (get) Token: 0x06018EAA RID: 102058 RVA: 0x003A043A File Offset: 0x0039E63A
		// (set) Token: 0x06018EAB RID: 102059 RVA: 0x003A0442 File Offset: 0x0039E642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x1700540A RID: 21514
		// (get) Token: 0x06018EAC RID: 102060 RVA: 0x003A044B File Offset: 0x0039E64B
		// (set) Token: 0x06018EAD RID: 102061 RVA: 0x003A0453 File Offset: 0x0039E653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityRewardState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06018EAE RID: 102062 RVA: 0x003A045C File Offset: 0x0039E65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinRewardActivityRewardInfo);
		}

		// Token: 0x06018EAF RID: 102063 RVA: 0x003A046A File Offset: 0x0039E66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinRewardActivityRewardInfo other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018EB0 RID: 102064 RVA: 0x003A04A8 File Offset: 0x0039E6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.State != SkinRewardActivityRewardState.InitState)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018EB1 RID: 102065 RVA: 0x003A0506 File Offset: 0x0039E706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018EB2 RID: 102066 RVA: 0x003A0513 File Offset: 0x0039E713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018EB3 RID: 102067 RVA: 0x003A051C File Offset: 0x0039E71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.State != SkinRewardActivityRewardState.InitState)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018EB4 RID: 102068 RVA: 0x003A0574 File Offset: 0x0039E774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.State != SkinRewardActivityRewardState.InitState)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018EB5 RID: 102069 RVA: 0x003A05CC File Offset: 0x0039E7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkinRewardActivityRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.State != SkinRewardActivityRewardState.InitState)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018EB6 RID: 102070 RVA: 0x003A061C File Offset: 0x0039E81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018EB7 RID: 102071 RVA: 0x003A0628 File Offset: 0x0039E828
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = (SkinRewardActivityRewardState)input.ReadEnum();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040092F0 RID: 37616
		private static readonly MessageParser<SkinRewardActivityRewardInfo> _parser = new MessageParser<SkinRewardActivityRewardInfo>(() => new SkinRewardActivityRewardInfo());

		// Token: 0x040092F1 RID: 37617
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092F2 RID: 37618
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040092F3 RID: 37619
		private int configId_;

		// Token: 0x040092F4 RID: 37620
		public const int StateFieldNumber = 2;

		// Token: 0x040092F5 RID: 37621
		private SkinRewardActivityRewardState state_;
	}
}
