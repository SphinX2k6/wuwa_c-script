using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000765 RID: 1893
	[NetMessage(EMessageId.HonamiStoryAreaSecretRewardResponse)]
	public sealed class HonamiStoryAreaSecretRewardResponse : IMessage<HonamiStoryAreaSecretRewardResponse>, IMessage, IEquatable<HonamiStoryAreaSecretRewardResponse>, IDeepCloneable<HonamiStoryAreaSecretRewardResponse>, IBufferMessage
	{
		// Token: 0x0600AB4B RID: 43851 RVA: 0x0019C355 File Offset: 0x0019A555
		[NullableContext(1)]
		public static HonamiStoryAreaSecretRewardResponse Create()
		{
			return new HonamiStoryAreaSecretRewardResponse();
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x0600AB4C RID: 43852 RVA: 0x0019C35C File Offset: 0x0019A55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x0600AB4D RID: 43853 RVA: 0x0019C35F File Offset: 0x0019A55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaSecretRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600AB4E RID: 43854 RVA: 0x0019C366 File Offset: 0x0019A566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardResponse()
		{
		}

		// Token: 0x0600AB4F RID: 43855 RVA: 0x0019C36E File Offset: 0x0019A56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardResponse(HonamiStoryAreaSecretRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB50 RID: 43856 RVA: 0x0019C393 File Offset: 0x0019A593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaSecretRewardResponse Clone()
		{
			return new HonamiStoryAreaSecretRewardResponse(this);
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x0600AB51 RID: 43857 RVA: 0x0019C39B File Offset: 0x0019A59B
		// (set) Token: 0x0600AB52 RID: 43858 RVA: 0x0019C3A3 File Offset: 0x0019A5A3
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

		// Token: 0x0600AB53 RID: 43859 RVA: 0x0019C3AC File Offset: 0x0019A5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaSecretRewardResponse);
		}

		// Token: 0x0600AB54 RID: 43860 RVA: 0x0019C3BA File Offset: 0x0019A5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaSecretRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x0019C3E8 File Offset: 0x0019A5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB56 RID: 43862 RVA: 0x0019C42D File Offset: 0x0019A62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x0019C43A File Offset: 0x0019A63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x0019C443 File Offset: 0x0019A643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x0019C478 File Offset: 0x0019A678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB5A RID: 43866 RVA: 0x0019C4B6 File Offset: 0x0019A6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaSecretRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB5B RID: 43867 RVA: 0x0019C4E7 File Offset: 0x0019A6E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB5C RID: 43868 RVA: 0x0019C4F0 File Offset: 0x0019A6F0
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004DCC RID: 19916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DCD RID: 19917
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04004DCE RID: 19918
		private ErrorCode errorCode_;
	}
}
