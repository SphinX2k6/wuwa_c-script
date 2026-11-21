using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF5 RID: 3317
	[NetMessage(EMessageId.PhantomSettingUpdateResponse)]
	public sealed class PhantomSettingUpdateResponse : IMessage<PhantomSettingUpdateResponse>, IMessage, IEquatable<PhantomSettingUpdateResponse>, IDeepCloneable<PhantomSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x06011F3B RID: 73531 RVA: 0x002A05A2 File Offset: 0x0029E7A2
		[NullableContext(1)]
		public static PhantomSettingUpdateResponse Create()
		{
			return new PhantomSettingUpdateResponse();
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x06011F3C RID: 73532 RVA: 0x002A05A9 File Offset: 0x0029E7A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x06011F3D RID: 73533 RVA: 0x002A05AC File Offset: 0x0029E7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06011F3E RID: 73534 RVA: 0x002A05B3 File Offset: 0x0029E7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateResponse()
		{
		}

		// Token: 0x06011F3F RID: 73535 RVA: 0x002A05BC File Offset: 0x0029E7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateResponse(PhantomSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F40 RID: 73536 RVA: 0x002A0608 File Offset: 0x0029E808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingUpdateResponse Clone()
		{
			return new PhantomSettingUpdateResponse(this);
		}

		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x06011F41 RID: 73537 RVA: 0x002A0610 File Offset: 0x0029E810
		// (set) Token: 0x06011F42 RID: 73538 RVA: 0x002A0618 File Offset: 0x0029E818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x06011F43 RID: 73539 RVA: 0x002A0621 File Offset: 0x0029E821
		// (set) Token: 0x06011F44 RID: 73540 RVA: 0x002A0629 File Offset: 0x0029E829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnePhantomSetting Setting
		{
			get
			{
				return this.setting_;
			}
			set
			{
				this.setting_ = value;
			}
		}

		// Token: 0x06011F45 RID: 73541 RVA: 0x002A0632 File Offset: 0x0029E832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingUpdateResponse);
		}

		// Token: 0x06011F46 RID: 73542 RVA: 0x002A0640 File Offset: 0x0029E840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Setting, other.Setting) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F47 RID: 73543 RVA: 0x002A0690 File Offset: 0x0029E890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.setting_ != null)
			{
				num ^= this.Setting.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011F48 RID: 73544 RVA: 0x002A06EB File Offset: 0x0029E8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F49 RID: 73545 RVA: 0x002A06F8 File Offset: 0x0029E8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F4A RID: 73546 RVA: 0x002A0704 File Offset: 0x0029E904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.setting_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Setting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F4B RID: 73547 RVA: 0x002A075C File Offset: 0x0029E95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.setting_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Setting);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011F4C RID: 73548 RVA: 0x002A07B4 File Offset: 0x0029E9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSettingUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.setting_ != null)
			{
				if (this.setting_ == null)
				{
					this.Setting = new OnePhantomSetting();
				}
				this.Setting.MergeFrom(other.Setting);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011F4D RID: 73549 RVA: 0x002A081C File Offset: 0x0029EA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F4E RID: 73550 RVA: 0x002A0828 File Offset: 0x0029EA28
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.setting_ == null)
						{
							this.Setting = new OnePhantomSetting();
						}
						input.ReadMessage(this.Setting);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040070EB RID: 28907
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070EC RID: 28908
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040070ED RID: 28909
		private ErrorCode errorCode_;

		// Token: 0x040070EE RID: 28910
		public const int SettingFieldNumber = 12;

		// Token: 0x040070EF RID: 28911
		private OnePhantomSetting setting_;
	}
}
