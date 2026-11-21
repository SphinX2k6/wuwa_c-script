using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F6 RID: 758
	public sealed class ControlParam : IMessage<ControlParam>, IMessage, IEquatable<ControlParam>, IDeepCloneable<ControlParam>, IBufferMessage
	{
		// Token: 0x06004D08 RID: 19720 RVA: 0x000BBA35 File Offset: 0x000B9C35
		[NullableContext(1)]
		public static ControlParam Create()
		{
			return new ControlParam();
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06004D09 RID: 19721 RVA: 0x000BBA3C File Offset: 0x000B9C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ControlParam> Parser
		{
			get
			{
				return ControlParam._parser;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x000BBA43 File Offset: 0x000B9C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06004D0B RID: 19723 RVA: 0x000BBA46 File Offset: 0x000B9C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ControlParam.Descriptor;
			}
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x000BBA4D File Offset: 0x000B9C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlParam()
		{
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x000BBA55 File Offset: 0x000B9C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlParam(ControlParam other) : this()
		{
			this.controlType_ = other.controlType_;
			if (other.ParamCase == ControlParam.ParamOneofCase.TemporaryTeleportParam)
			{
				this.TemporaryTeleportParam = other.TemporaryTeleportParam.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x000BBA94 File Offset: 0x000B9C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlParam Clone()
		{
			return new ControlParam(this);
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06004D0F RID: 19727 RVA: 0x000BBA9C File Offset: 0x000B9C9C
		// (set) Token: 0x06004D10 RID: 19728 RVA: 0x000BBAA4 File Offset: 0x000B9CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlType ControlType
		{
			get
			{
				return this.controlType_;
			}
			set
			{
				this.controlType_ = value;
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06004D11 RID: 19729 RVA: 0x000BBAAD File Offset: 0x000B9CAD
		// (set) Token: 0x06004D12 RID: 19730 RVA: 0x000BBAC5 File Offset: 0x000B9CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlTemporaryTeleportParam TemporaryTeleportParam
		{
			get
			{
				if (this.paramCase_ != ControlParam.ParamOneofCase.TemporaryTeleportParam)
				{
					return null;
				}
				return (ControlTemporaryTeleportParam)this.param_;
			}
			set
			{
				this.param_ = value;
				this.paramCase_ = ((value == null) ? ControlParam.ParamOneofCase.None : ControlParam.ParamOneofCase.TemporaryTeleportParam);
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06004D13 RID: 19731 RVA: 0x000BBADB File Offset: 0x000B9CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ControlParam.ParamOneofCase ParamCase
		{
			get
			{
				return this.paramCase_;
			}
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x000BBAE3 File Offset: 0x000B9CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearParam()
		{
			this.paramCase_ = ControlParam.ParamOneofCase.None;
			this.param_ = null;
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x000BBAF3 File Offset: 0x000B9CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ControlParam);
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x000BBB04 File Offset: 0x000B9D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ControlParam other)
		{
			return other != null && (other == this || (this.ControlType == other.ControlType && object.Equals(this.TemporaryTeleportParam, other.TemporaryTeleportParam) && this.ParamCase == other.ParamCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x000BBB64 File Offset: 0x000B9D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ControlType != ControlType.Unknown)
			{
				num ^= this.ControlType.GetHashCode();
			}
			if (this.paramCase_ == ControlParam.ParamOneofCase.TemporaryTeleportParam)
			{
				num ^= this.TemporaryTeleportParam.GetHashCode();
			}
			num ^= (int)this.paramCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x000BBBC9 File Offset: 0x000B9DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x000BBBD6 File Offset: 0x000B9DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x000BBBE0 File Offset: 0x000B9DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ControlType != ControlType.Unknown)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ControlType);
			}
			if (this.paramCase_ == ControlParam.ParamOneofCase.TemporaryTeleportParam)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TemporaryTeleportParam);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x000BBC3C File Offset: 0x000B9E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ControlType != ControlType.Unknown)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ControlType);
			}
			if (this.paramCase_ == ControlParam.ParamOneofCase.TemporaryTeleportParam)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TemporaryTeleportParam);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x000BBC94 File Offset: 0x000B9E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ControlParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ControlType != ControlType.Unknown)
			{
				this.ControlType = other.ControlType;
			}
			if (other.ParamCase == ControlParam.ParamOneofCase.TemporaryTeleportParam)
			{
				if (this.TemporaryTeleportParam == null)
				{
					this.TemporaryTeleportParam = new ControlTemporaryTeleportParam();
				}
				this.TemporaryTeleportParam.MergeFrom(other.TemporaryTeleportParam);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x000BBCFD File Offset: 0x000B9EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x000BBD08 File Offset: 0x000B9F08
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						ControlTemporaryTeleportParam controlTemporaryTeleportParam = new ControlTemporaryTeleportParam();
						if (this.paramCase_ == ControlParam.ParamOneofCase.TemporaryTeleportParam)
						{
							controlTemporaryTeleportParam.MergeFrom(this.TemporaryTeleportParam);
						}
						input.ReadMessage(controlTemporaryTeleportParam);
						this.TemporaryTeleportParam = controlTemporaryTeleportParam;
					}
				}
				else
				{
					this.ControlType = (ControlType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400317D RID: 12669
		private static readonly MessageParser<ControlParam> _parser = new MessageParser<ControlParam>(() => new ControlParam());

		// Token: 0x0400317E RID: 12670
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400317F RID: 12671
		public const int ControlTypeFieldNumber = 1;

		// Token: 0x04003180 RID: 12672
		private ControlType controlType_;

		// Token: 0x04003181 RID: 12673
		public const int TemporaryTeleportParamFieldNumber = 2;

		// Token: 0x04003182 RID: 12674
		private object param_;

		// Token: 0x04003183 RID: 12675
		private ControlParam.ParamOneofCase paramCase_;

		// Token: 0x020017AA RID: 6058
		public enum ParamOneofCase
		{
			// Token: 0x0400CAC6 RID: 51910
			None,
			// Token: 0x0400CAC7 RID: 51911
			TemporaryTeleportParam = 2
		}
	}
}
