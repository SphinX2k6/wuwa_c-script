using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A68 RID: 2664
	[NetMessage(EMessageId.MotorFightSettleRequest)]
	public sealed class MotorFightSettleRequest : IMessage<MotorFightSettleRequest>, IMessage, IEquatable<MotorFightSettleRequest>, IDeepCloneable<MotorFightSettleRequest>, IBufferMessage
	{
		// Token: 0x0600E866 RID: 59494 RVA: 0x0021F549 File Offset: 0x0021D749
		[NullableContext(1)]
		public static MotorFightSettleRequest Create()
		{
			return new MotorFightSettleRequest();
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0600E867 RID: 59495 RVA: 0x0021F550 File Offset: 0x0021D750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0600E868 RID: 59496 RVA: 0x0021F553 File Offset: 0x0021D753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSettleRequest.Descriptor;
			}
		}

		// Token: 0x0600E869 RID: 59497 RVA: 0x0021F55A File Offset: 0x0021D75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleRequest()
		{
		}

		// Token: 0x0600E86A RID: 59498 RVA: 0x0021F562 File Offset: 0x0021D762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleRequest(MotorFightSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E86B RID: 59499 RVA: 0x0021F57B File Offset: 0x0021D77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleRequest Clone()
		{
			return new MotorFightSettleRequest(this);
		}

		// Token: 0x0600E86C RID: 59500 RVA: 0x0021F583 File Offset: 0x0021D783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSettleRequest);
		}

		// Token: 0x0600E86D RID: 59501 RVA: 0x0021F591 File Offset: 0x0021D791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E86E RID: 59502 RVA: 0x0021F5B0 File Offset: 0x0021D7B0
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

		// Token: 0x0600E86F RID: 59503 RVA: 0x0021F5D6 File Offset: 0x0021D7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E870 RID: 59504 RVA: 0x0021F5E3 File Offset: 0x0021D7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E871 RID: 59505 RVA: 0x0021F5EC File Offset: 0x0021D7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E872 RID: 59506 RVA: 0x0021F604 File Offset: 0x0021D804
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

		// Token: 0x0600E873 RID: 59507 RVA: 0x0021F62A File Offset: 0x0021D82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E874 RID: 59508 RVA: 0x0021F647 File Offset: 0x0021D847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E875 RID: 59509 RVA: 0x0021F650 File Offset: 0x0021D850
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

		// Token: 0x04005EA9 RID: 24233
		private UnknownFieldSet _unknownFields;
	}
}
