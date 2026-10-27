using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4E RID: 2638
	[NetMessage(EMessageId.MotorFightPlayerDeadRequest)]
	public sealed class MotorFightPlayerDeadRequest : IMessage<MotorFightPlayerDeadRequest>, IMessage, IEquatable<MotorFightPlayerDeadRequest>, IDeepCloneable<MotorFightPlayerDeadRequest>, IBufferMessage
	{
		// Token: 0x0600E637 RID: 58935 RVA: 0x0021A3E1 File Offset: 0x002185E1
		[NullableContext(1)]
		public static MotorFightPlayerDeadRequest Create()
		{
			return new MotorFightPlayerDeadRequest();
		}

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x0600E638 RID: 58936 RVA: 0x0021A3E8 File Offset: 0x002185E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x0600E639 RID: 58937 RVA: 0x0021A3EB File Offset: 0x002185EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightPlayerDeadRequest.Descriptor;
			}
		}

		// Token: 0x0600E63A RID: 58938 RVA: 0x0021A3F2 File Offset: 0x002185F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadRequest()
		{
		}

		// Token: 0x0600E63B RID: 58939 RVA: 0x0021A3FA File Offset: 0x002185FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadRequest(MotorFightPlayerDeadRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E63C RID: 58940 RVA: 0x0021A413 File Offset: 0x00218613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadRequest Clone()
		{
			return new MotorFightPlayerDeadRequest(this);
		}

		// Token: 0x0600E63D RID: 58941 RVA: 0x0021A41B File Offset: 0x0021861B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightPlayerDeadRequest);
		}

		// Token: 0x0600E63E RID: 58942 RVA: 0x0021A429 File Offset: 0x00218629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightPlayerDeadRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E63F RID: 58943 RVA: 0x0021A448 File Offset: 0x00218648
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

		// Token: 0x0600E640 RID: 58944 RVA: 0x0021A46E File Offset: 0x0021866E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E641 RID: 58945 RVA: 0x0021A47B File Offset: 0x0021867B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E642 RID: 58946 RVA: 0x0021A484 File Offset: 0x00218684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E643 RID: 58947 RVA: 0x0021A49C File Offset: 0x0021869C
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

		// Token: 0x0600E644 RID: 58948 RVA: 0x0021A4C2 File Offset: 0x002186C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightPlayerDeadRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E645 RID: 58949 RVA: 0x0021A4DF File Offset: 0x002186DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E646 RID: 58950 RVA: 0x0021A4E8 File Offset: 0x002186E8
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

		// Token: 0x04005DF5 RID: 24053
		private UnknownFieldSet _unknownFields;
	}
}
