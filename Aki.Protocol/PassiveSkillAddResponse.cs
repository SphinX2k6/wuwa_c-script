using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BCE RID: 3022
	[NetMessage(EMessageId.PassiveSkillAddResponse)]
	public sealed class PassiveSkillAddResponse : IMessage<PassiveSkillAddResponse>, IMessage, IEquatable<PassiveSkillAddResponse>, IDeepCloneable<PassiveSkillAddResponse>, IBufferMessage
	{
		// Token: 0x060105E9 RID: 67049 RVA: 0x002632F4 File Offset: 0x002614F4
		[NullableContext(1)]
		public static PassiveSkillAddResponse Create()
		{
			return new PassiveSkillAddResponse();
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x060105EA RID: 67050 RVA: 0x002632FB File Offset: 0x002614FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x060105EB RID: 67051 RVA: 0x002632FE File Offset: 0x002614FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillAddResponse.Descriptor;
			}
		}

		// Token: 0x060105EC RID: 67052 RVA: 0x00263305 File Offset: 0x00261505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddResponse()
		{
		}

		// Token: 0x060105ED RID: 67053 RVA: 0x0026330D File Offset: 0x0026150D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddResponse(PassiveSkillAddResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060105EE RID: 67054 RVA: 0x00263332 File Offset: 0x00261532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddResponse Clone()
		{
			return new PassiveSkillAddResponse(this);
		}

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x060105EF RID: 67055 RVA: 0x0026333A File Offset: 0x0026153A
		// (set) Token: 0x060105F0 RID: 67056 RVA: 0x00263342 File Offset: 0x00261542
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

		// Token: 0x060105F1 RID: 67057 RVA: 0x0026334B File Offset: 0x0026154B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillAddResponse);
		}

		// Token: 0x060105F2 RID: 67058 RVA: 0x00263359 File Offset: 0x00261559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillAddResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060105F3 RID: 67059 RVA: 0x00263388 File Offset: 0x00261588
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

		// Token: 0x060105F4 RID: 67060 RVA: 0x002633CD File Offset: 0x002615CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060105F5 RID: 67061 RVA: 0x002633DA File Offset: 0x002615DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060105F6 RID: 67062 RVA: 0x002633E3 File Offset: 0x002615E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060105F7 RID: 67063 RVA: 0x00263418 File Offset: 0x00261618
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

		// Token: 0x060105F8 RID: 67064 RVA: 0x00263456 File Offset: 0x00261656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillAddResponse other)
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

		// Token: 0x060105F9 RID: 67065 RVA: 0x00263487 File Offset: 0x00261687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060105FA RID: 67066 RVA: 0x00263490 File Offset: 0x00261690
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040067EE RID: 26606
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067EF RID: 26607
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040067F0 RID: 26608
		private ErrorCode errorCode_;
	}
}
