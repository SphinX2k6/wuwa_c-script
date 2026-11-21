using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001178 RID: 4472
	[NetMessage(EMessageId.RunTestResponse)]
	public sealed class RunTestResponse : IMessage<RunTestResponse>, IMessage, IEquatable<RunTestResponse>, IDeepCloneable<RunTestResponse>, IBufferMessage
	{
		// Token: 0x06017E3B RID: 97851 RVA: 0x0037A2C4 File Offset: 0x003784C4
		[NullableContext(1)]
		public static RunTestResponse Create()
		{
			return new RunTestResponse();
		}

		// Token: 0x1700506A RID: 20586
		// (get) Token: 0x06017E3C RID: 97852 RVA: 0x0037A2CB File Offset: 0x003784CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700506B RID: 20587
		// (get) Token: 0x06017E3D RID: 97853 RVA: 0x0037A2CE File Offset: 0x003784CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RunTestResponse.Descriptor;
			}
		}

		// Token: 0x06017E3E RID: 97854 RVA: 0x0037A2D5 File Offset: 0x003784D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestResponse()
		{
		}

		// Token: 0x06017E3F RID: 97855 RVA: 0x0037A2DD File Offset: 0x003784DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestResponse(RunTestResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E40 RID: 97856 RVA: 0x0037A302 File Offset: 0x00378502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTestResponse Clone()
		{
			return new RunTestResponse(this);
		}

		// Token: 0x1700506C RID: 20588
		// (get) Token: 0x06017E41 RID: 97857 RVA: 0x0037A30A File Offset: 0x0037850A
		// (set) Token: 0x06017E42 RID: 97858 RVA: 0x0037A312 File Offset: 0x00378512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06017E43 RID: 97859 RVA: 0x0037A31B File Offset: 0x0037851B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RunTestResponse);
		}

		// Token: 0x06017E44 RID: 97860 RVA: 0x0037A329 File Offset: 0x00378529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RunTestResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E45 RID: 97861 RVA: 0x0037A358 File Offset: 0x00378558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017E46 RID: 97862 RVA: 0x0037A39D File Offset: 0x0037859D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E47 RID: 97863 RVA: 0x0037A3AA File Offset: 0x003785AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E48 RID: 97864 RVA: 0x0037A3B3 File Offset: 0x003785B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E49 RID: 97865 RVA: 0x0037A3E8 File Offset: 0x003785E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017E4A RID: 97866 RVA: 0x0037A426 File Offset: 0x00378626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RunTestResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017E4B RID: 97867 RVA: 0x0037A457 File Offset: 0x00378657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E4C RID: 97868 RVA: 0x0037A460 File Offset: 0x00378660
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008E65 RID: 36453
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E66 RID: 36454
		public const int CodeFieldNumber = 15;

		// Token: 0x04008E67 RID: 36455
		private ErrorCode code_;
	}
}
