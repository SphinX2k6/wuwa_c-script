using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B6 RID: 950
	[NetMessage(EMessageId.DarkTideSwitchVisionResponse)]
	public sealed class DarkTideSwitchVisionResponse : IMessage<DarkTideSwitchVisionResponse>, IMessage, IEquatable<DarkTideSwitchVisionResponse>, IDeepCloneable<DarkTideSwitchVisionResponse>, IBufferMessage
	{
		// Token: 0x06005D27 RID: 23847 RVA: 0x000E21E9 File Offset: 0x000E03E9
		[NullableContext(1)]
		public static DarkTideSwitchVisionResponse Create()
		{
			return new DarkTideSwitchVisionResponse();
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06005D28 RID: 23848 RVA: 0x000E21F0 File Offset: 0x000E03F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06005D29 RID: 23849 RVA: 0x000E21F3 File Offset: 0x000E03F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideSwitchVisionResponse.Descriptor;
			}
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x000E21FA File Offset: 0x000E03FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideSwitchVisionResponse()
		{
		}

		// Token: 0x06005D2B RID: 23851 RVA: 0x000E2202 File Offset: 0x000E0402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideSwitchVisionResponse(DarkTideSwitchVisionResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.selectVisionIndex_ = other.selectVisionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D2C RID: 23852 RVA: 0x000E2233 File Offset: 0x000E0433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideSwitchVisionResponse Clone()
		{
			return new DarkTideSwitchVisionResponse(this);
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06005D2D RID: 23853 RVA: 0x000E223B File Offset: 0x000E043B
		// (set) Token: 0x06005D2E RID: 23854 RVA: 0x000E2243 File Offset: 0x000E0443
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

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06005D2F RID: 23855 RVA: 0x000E224C File Offset: 0x000E044C
		// (set) Token: 0x06005D30 RID: 23856 RVA: 0x000E2254 File Offset: 0x000E0454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectVisionIndex
		{
			get
			{
				return this.selectVisionIndex_;
			}
			set
			{
				this.selectVisionIndex_ = value;
			}
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x000E225D File Offset: 0x000E045D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideSwitchVisionResponse);
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x000E226B File Offset: 0x000E046B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideSwitchVisionResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SelectVisionIndex == other.SelectVisionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x000E22AC File Offset: 0x000E04AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.SelectVisionIndex != 0)
			{
				num ^= this.SelectVisionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x000E230A File Offset: 0x000E050A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x000E2317 File Offset: 0x000E0517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D36 RID: 23862 RVA: 0x000E2320 File Offset: 0x000E0520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.SelectVisionIndex != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SelectVisionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D37 RID: 23863 RVA: 0x000E237C File Offset: 0x000E057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.SelectVisionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectVisionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D38 RID: 23864 RVA: 0x000E23D4 File Offset: 0x000E05D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideSwitchVisionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.SelectVisionIndex != 0)
			{
				this.SelectVisionIndex = other.SelectVisionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x000E2424 File Offset: 0x000E0624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x000E2430 File Offset: 0x000E0630
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SelectVisionIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003678 RID: 13944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003679 RID: 13945
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400367A RID: 13946
		private ErrorCode errorCode_;

		// Token: 0x0400367B RID: 13947
		public const int SelectVisionIndexFieldNumber = 12;

		// Token: 0x0400367C RID: 13948
		private int selectVisionIndex_;
	}
}
