using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001181 RID: 4481
	[NetMessage(EMessageId.SceneModeChangeFinishResponse)]
	public sealed class SceneModeChangeFinishResponse : IMessage<SceneModeChangeFinishResponse>, IMessage, IEquatable<SceneModeChangeFinishResponse>, IDeepCloneable<SceneModeChangeFinishResponse>, IBufferMessage
	{
		// Token: 0x06017E0F RID: 97807 RVA: 0x00377836 File Offset: 0x00375A36
		[NullableContext(1)]
		public static SceneModeChangeFinishResponse Create()
		{
			return new SceneModeChangeFinishResponse();
		}

		// Token: 0x17005030 RID: 20528
		// (get) Token: 0x06017E10 RID: 97808 RVA: 0x0037783D File Offset: 0x00375A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005031 RID: 20529
		// (get) Token: 0x06017E11 RID: 97809 RVA: 0x00377840 File Offset: 0x00375A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneModeChangeFinishResponse.Descriptor;
			}
		}

		// Token: 0x06017E12 RID: 97810 RVA: 0x00377847 File Offset: 0x00375A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishResponse()
		{
		}

		// Token: 0x06017E13 RID: 97811 RVA: 0x0037784F File Offset: 0x00375A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishResponse(SceneModeChangeFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E14 RID: 97812 RVA: 0x00377874 File Offset: 0x00375A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneModeChangeFinishResponse Clone()
		{
			return new SceneModeChangeFinishResponse(this);
		}

		// Token: 0x17005032 RID: 20530
		// (get) Token: 0x06017E15 RID: 97813 RVA: 0x0037787C File Offset: 0x00375A7C
		// (set) Token: 0x06017E16 RID: 97814 RVA: 0x00377884 File Offset: 0x00375A84
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

		// Token: 0x06017E17 RID: 97815 RVA: 0x0037788D File Offset: 0x00375A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneModeChangeFinishResponse);
		}

		// Token: 0x06017E18 RID: 97816 RVA: 0x0037789B File Offset: 0x00375A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneModeChangeFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E19 RID: 97817 RVA: 0x003778CC File Offset: 0x00375ACC
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

		// Token: 0x06017E1A RID: 97818 RVA: 0x00377911 File Offset: 0x00375B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E1B RID: 97819 RVA: 0x0037791E File Offset: 0x00375B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E1C RID: 97820 RVA: 0x00377927 File Offset: 0x00375B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E1D RID: 97821 RVA: 0x0037795C File Offset: 0x00375B5C
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

		// Token: 0x06017E1E RID: 97822 RVA: 0x0037799A File Offset: 0x00375B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneModeChangeFinishResponse other)
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

		// Token: 0x06017E1F RID: 97823 RVA: 0x003779CB File Offset: 0x00375BCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E20 RID: 97824 RVA: 0x003779D4 File Offset: 0x00375BD4
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008D72 RID: 36210
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D73 RID: 36211
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04008D74 RID: 36212
		private ErrorCode errorCode_;
	}
}
