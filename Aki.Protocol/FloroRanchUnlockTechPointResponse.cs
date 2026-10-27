using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005ED RID: 1517
	[NetMessage(EMessageId.FloroRanchUnlockTechPointResponse)]
	public sealed class FloroRanchUnlockTechPointResponse : IMessage<FloroRanchUnlockTechPointResponse>, IMessage, IEquatable<FloroRanchUnlockTechPointResponse>, IDeepCloneable<FloroRanchUnlockTechPointResponse>, IBufferMessage
	{
		// Token: 0x06008C76 RID: 35958 RVA: 0x00154740 File Offset: 0x00152940
		[NullableContext(1)]
		public static FloroRanchUnlockTechPointResponse Create()
		{
			return new FloroRanchUnlockTechPointResponse();
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06008C77 RID: 35959 RVA: 0x00154747 File Offset: 0x00152947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06008C78 RID: 35960 RVA: 0x0015474A File Offset: 0x0015294A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchUnlockTechPointResponse.Descriptor;
			}
		}

		// Token: 0x06008C79 RID: 35961 RVA: 0x00154751 File Offset: 0x00152951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointResponse()
		{
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x00154759 File Offset: 0x00152959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointResponse(FloroRanchUnlockTechPointResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C7B RID: 35963 RVA: 0x0015477E File Offset: 0x0015297E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchUnlockTechPointResponse Clone()
		{
			return new FloroRanchUnlockTechPointResponse(this);
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06008C7C RID: 35964 RVA: 0x00154786 File Offset: 0x00152986
		// (set) Token: 0x06008C7D RID: 35965 RVA: 0x0015478E File Offset: 0x0015298E
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

		// Token: 0x06008C7E RID: 35966 RVA: 0x00154797 File Offset: 0x00152997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchUnlockTechPointResponse);
		}

		// Token: 0x06008C7F RID: 35967 RVA: 0x001547A5 File Offset: 0x001529A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchUnlockTechPointResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C80 RID: 35968 RVA: 0x001547D4 File Offset: 0x001529D4
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

		// Token: 0x06008C81 RID: 35969 RVA: 0x00154819 File Offset: 0x00152A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x00154826 File Offset: 0x00152A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C83 RID: 35971 RVA: 0x0015482F File Offset: 0x00152A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x00154864 File Offset: 0x00152A64
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

		// Token: 0x06008C85 RID: 35973 RVA: 0x001548A2 File Offset: 0x00152AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchUnlockTechPointResponse other)
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

		// Token: 0x06008C86 RID: 35974 RVA: 0x001548D3 File Offset: 0x00152AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x001548DC File Offset: 0x00152ADC
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040044C2 RID: 17602
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044C3 RID: 17603
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040044C4 RID: 17604
		private ErrorCode errorCode_;
	}
}
