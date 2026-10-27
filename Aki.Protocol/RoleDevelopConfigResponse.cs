using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001065 RID: 4197
	[NetMessage(EMessageId.RoleDevelopConfigResponse)]
	public sealed class RoleDevelopConfigResponse : IMessage<RoleDevelopConfigResponse>, IMessage, IEquatable<RoleDevelopConfigResponse>, IDeepCloneable<RoleDevelopConfigResponse>, IBufferMessage
	{
		// Token: 0x060166C0 RID: 91840 RVA: 0x00341F81 File Offset: 0x00340181
		[NullableContext(1)]
		public static RoleDevelopConfigResponse Create()
		{
			return new RoleDevelopConfigResponse();
		}

		// Token: 0x17004B03 RID: 19203
		// (get) Token: 0x060166C1 RID: 91841 RVA: 0x00341F88 File Offset: 0x00340188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B04 RID: 19204
		// (get) Token: 0x060166C2 RID: 91842 RVA: 0x00341F8B File Offset: 0x0034018B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevelopConfigResponse.Descriptor;
			}
		}

		// Token: 0x060166C3 RID: 91843 RVA: 0x00341F92 File Offset: 0x00340192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigResponse()
		{
		}

		// Token: 0x060166C4 RID: 91844 RVA: 0x00341F9C File Offset: 0x0034019C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigResponse(RoleDevelopConfigResponse other) : this()
		{
			this.configs_ = ((other.configs_ != null) ? other.configs_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060166C5 RID: 91845 RVA: 0x00341FE8 File Offset: 0x003401E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigResponse Clone()
		{
			return new RoleDevelopConfigResponse(this);
		}

		// Token: 0x17004B05 RID: 19205
		// (get) Token: 0x060166C6 RID: 91846 RVA: 0x00341FF0 File Offset: 0x003401F0
		// (set) Token: 0x060166C7 RID: 91847 RVA: 0x00341FF8 File Offset: 0x003401F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigs Configs
		{
			get
			{
				return this.configs_;
			}
			set
			{
				this.configs_ = value;
			}
		}

		// Token: 0x17004B06 RID: 19206
		// (get) Token: 0x060166C8 RID: 91848 RVA: 0x00342001 File Offset: 0x00340201
		// (set) Token: 0x060166C9 RID: 91849 RVA: 0x00342009 File Offset: 0x00340209
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

		// Token: 0x060166CA RID: 91850 RVA: 0x00342012 File Offset: 0x00340212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevelopConfigResponse);
		}

		// Token: 0x060166CB RID: 91851 RVA: 0x00342020 File Offset: 0x00340220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevelopConfigResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Configs, other.Configs) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060166CC RID: 91852 RVA: 0x00342070 File Offset: 0x00340270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.configs_ != null)
			{
				num ^= this.Configs.GetHashCode();
			}
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

		// Token: 0x060166CD RID: 91853 RVA: 0x003420CB File Offset: 0x003402CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060166CE RID: 91854 RVA: 0x003420D8 File Offset: 0x003402D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060166CF RID: 91855 RVA: 0x003420E4 File Offset: 0x003402E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.configs_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Configs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060166D0 RID: 91856 RVA: 0x00342140 File Offset: 0x00340340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.configs_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Configs);
			}
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

		// Token: 0x060166D1 RID: 91857 RVA: 0x00342198 File Offset: 0x00340398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleDevelopConfigResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.configs_ != null)
			{
				if (this.configs_ == null)
				{
					this.Configs = new RoleDevelopConfigs();
				}
				this.Configs.MergeFrom(other.Configs);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060166D2 RID: 91858 RVA: 0x00342200 File Offset: 0x00340400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060166D3 RID: 91859 RVA: 0x0034220C File Offset: 0x0034040C
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
				if (num != 80U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.configs_ == null)
						{
							this.Configs = new RoleDevelopConfigs();
						}
						input.ReadMessage(this.Configs);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400860B RID: 34315
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400860C RID: 34316
		public const int ConfigsFieldNumber = 12;

		// Token: 0x0400860D RID: 34317
		private RoleDevelopConfigs configs_;

		// Token: 0x0400860E RID: 34318
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400860F RID: 34319
		private ErrorCode errorCode_;
	}
}
