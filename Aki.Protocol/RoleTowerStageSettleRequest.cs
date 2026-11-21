using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F2 RID: 4338
	[NetMessage(EMessageId.RoleTowerStageSettleRequest)]
	public sealed class RoleTowerStageSettleRequest : IMessage<RoleTowerStageSettleRequest>, IMessage, IEquatable<RoleTowerStageSettleRequest>, IDeepCloneable<RoleTowerStageSettleRequest>, IBufferMessage
	{
		// Token: 0x06017316 RID: 94998 RVA: 0x0036003E File Offset: 0x0035E23E
		[NullableContext(1)]
		public static RoleTowerStageSettleRequest Create()
		{
			return new RoleTowerStageSettleRequest();
		}

		// Token: 0x17004DEA RID: 19946
		// (get) Token: 0x06017317 RID: 94999 RVA: 0x00360045 File Offset: 0x0035E245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DEB RID: 19947
		// (get) Token: 0x06017318 RID: 95000 RVA: 0x00360048 File Offset: 0x0035E248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerStageSettleRequest.Descriptor;
			}
		}

		// Token: 0x06017319 RID: 95001 RVA: 0x0036004F File Offset: 0x0035E24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageSettleRequest()
		{
		}

		// Token: 0x0601731A RID: 95002 RVA: 0x00360057 File Offset: 0x0035E257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageSettleRequest(RoleTowerStageSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601731B RID: 95003 RVA: 0x00360070 File Offset: 0x0035E270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageSettleRequest Clone()
		{
			return new RoleTowerStageSettleRequest(this);
		}

		// Token: 0x0601731C RID: 95004 RVA: 0x00360078 File Offset: 0x0035E278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerStageSettleRequest);
		}

		// Token: 0x0601731D RID: 95005 RVA: 0x00360086 File Offset: 0x0035E286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerStageSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601731E RID: 95006 RVA: 0x003600A4 File Offset: 0x0035E2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601731F RID: 95007 RVA: 0x003600CA File Offset: 0x0035E2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017320 RID: 95008 RVA: 0x003600D7 File Offset: 0x0035E2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017321 RID: 95009 RVA: 0x003600E0 File Offset: 0x0035E2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017322 RID: 95010 RVA: 0x003600F8 File Offset: 0x0035E2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017323 RID: 95011 RVA: 0x0036011E File Offset: 0x0035E31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerStageSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017324 RID: 95012 RVA: 0x0036013B File Offset: 0x0035E33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017325 RID: 95013 RVA: 0x00360144 File Offset: 0x0035E344
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008ACF RID: 35535
		private UnknownFieldSet _unknownFields;
	}
}
