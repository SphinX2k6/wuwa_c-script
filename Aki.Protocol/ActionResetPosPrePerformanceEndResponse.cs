using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000079 RID: 121
	[NetMessage(EMessageId.ActionResetPosPrePerformanceEndResponse)]
	public sealed class ActionResetPosPrePerformanceEndResponse : IMessage<ActionResetPosPrePerformanceEndResponse>, IMessage, IEquatable<ActionResetPosPrePerformanceEndResponse>, IDeepCloneable<ActionResetPosPrePerformanceEndResponse>, IBufferMessage
	{
		// Token: 0x0600185C RID: 6236 RVA: 0x0003FDA4 File Offset: 0x0003DFA4
		[NullableContext(1)]
		public static ActionResetPosPrePerformanceEndResponse Create()
		{
			return new ActionResetPosPrePerformanceEndResponse();
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x0003FDAB File Offset: 0x0003DFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0003FDAE File Offset: 0x0003DFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionResetPosPrePerformanceEndResponse.Descriptor;
			}
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0003FDB5 File Offset: 0x0003DFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndResponse()
		{
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0003FDBD File Offset: 0x0003DFBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndResponse(ActionResetPosPrePerformanceEndResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0003FDE2 File Offset: 0x0003DFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionResetPosPrePerformanceEndResponse Clone()
		{
			return new ActionResetPosPrePerformanceEndResponse(this);
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x0003FDEA File Offset: 0x0003DFEA
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x0003FDF2 File Offset: 0x0003DFF2
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

		// Token: 0x06001864 RID: 6244 RVA: 0x0003FDFB File Offset: 0x0003DFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionResetPosPrePerformanceEndResponse);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0003FE09 File Offset: 0x0003E009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionResetPosPrePerformanceEndResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0003FE38 File Offset: 0x0003E038
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

		// Token: 0x06001867 RID: 6247 RVA: 0x0003FE7D File Offset: 0x0003E07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0003FE8A File Offset: 0x0003E08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0003FE93 File Offset: 0x0003E093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0003FEC8 File Offset: 0x0003E0C8
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

		// Token: 0x0600186B RID: 6251 RVA: 0x0003FF06 File Offset: 0x0003E106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionResetPosPrePerformanceEndResponse other)
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

		// Token: 0x0600186C RID: 6252 RVA: 0x0003FF37 File Offset: 0x0003E137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0003FF40 File Offset: 0x0003E140
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040021C6 RID: 8646
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021C7 RID: 8647
		public const int CodeFieldNumber = 6;

		// Token: 0x040021C8 RID: 8648
		private ErrorCode code_;
	}
}
