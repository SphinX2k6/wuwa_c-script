using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004EC RID: 1260
	[NetMessage(EMessageId.ExitViewDirectionPush)]
	public sealed class ExitViewDirectionPush : IMessage<ExitViewDirectionPush>, IMessage, IEquatable<ExitViewDirectionPush>, IDeepCloneable<ExitViewDirectionPush>, IBufferMessage
	{
		// Token: 0x06007735 RID: 30517 RVA: 0x0012309A File Offset: 0x0012129A
		[NullableContext(1)]
		public static ExitViewDirectionPush Create()
		{
			return new ExitViewDirectionPush();
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06007736 RID: 30518 RVA: 0x001230A1 File Offset: 0x001212A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06007737 RID: 30519 RVA: 0x001230A4 File Offset: 0x001212A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExitViewDirectionPush.Descriptor;
			}
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x001230AB File Offset: 0x001212AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionPush()
		{
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x001230B3 File Offset: 0x001212B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionPush(ExitViewDirectionPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x001230CC File Offset: 0x001212CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionPush Clone()
		{
			return new ExitViewDirectionPush(this);
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x001230D4 File Offset: 0x001212D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExitViewDirectionPush);
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x001230E2 File Offset: 0x001212E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExitViewDirectionPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00123100 File Offset: 0x00121300
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

		// Token: 0x0600773E RID: 30526 RVA: 0x00123126 File Offset: 0x00121326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x00123133 File Offset: 0x00121333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x0012313C File Offset: 0x0012133C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x00123154 File Offset: 0x00121354
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

		// Token: 0x06007742 RID: 30530 RVA: 0x0012317A File Offset: 0x0012137A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExitViewDirectionPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x00123197 File Offset: 0x00121397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x001231A0 File Offset: 0x001213A0
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

		// Token: 0x04003E23 RID: 15907
		private UnknownFieldSet _unknownFields;
	}
}
