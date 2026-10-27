using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A20 RID: 2592
	[NetMessage(EMessageId.MotorBattleContextNotify)]
	public sealed class MotorBattleContextNotify : IMessage<MotorBattleContextNotify>, IMessage, IEquatable<MotorBattleContextNotify>, IDeepCloneable<MotorBattleContextNotify>, IBufferMessage
	{
		// Token: 0x0600E2AD RID: 58029 RVA: 0x002132B8 File Offset: 0x002114B8
		[NullableContext(1)]
		public static MotorBattleContextNotify Create()
		{
			return new MotorBattleContextNotify();
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x0600E2AE RID: 58030 RVA: 0x002132BF File Offset: 0x002114BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x0600E2AF RID: 58031 RVA: 0x002132C2 File Offset: 0x002114C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorBattleContextNotify.Descriptor;
			}
		}

		// Token: 0x0600E2B0 RID: 58032 RVA: 0x002132C9 File Offset: 0x002114C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorBattleContextNotify()
		{
		}

		// Token: 0x0600E2B1 RID: 58033 RVA: 0x002132D1 File Offset: 0x002114D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorBattleContextNotify(MotorBattleContextNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2B2 RID: 58034 RVA: 0x002132EA File Offset: 0x002114EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorBattleContextNotify Clone()
		{
			return new MotorBattleContextNotify(this);
		}

		// Token: 0x0600E2B3 RID: 58035 RVA: 0x002132F2 File Offset: 0x002114F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorBattleContextNotify);
		}

		// Token: 0x0600E2B4 RID: 58036 RVA: 0x00213300 File Offset: 0x00211500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorBattleContextNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E2B5 RID: 58037 RVA: 0x00213320 File Offset: 0x00211520
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

		// Token: 0x0600E2B6 RID: 58038 RVA: 0x00213346 File Offset: 0x00211546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E2B7 RID: 58039 RVA: 0x00213353 File Offset: 0x00211553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2B8 RID: 58040 RVA: 0x0021335C File Offset: 0x0021155C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2B9 RID: 58041 RVA: 0x00213374 File Offset: 0x00211574
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

		// Token: 0x0600E2BA RID: 58042 RVA: 0x0021339A File Offset: 0x0021159A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorBattleContextNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2BB RID: 58043 RVA: 0x002133B7 File Offset: 0x002115B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2BC RID: 58044 RVA: 0x002133C0 File Offset: 0x002115C0
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

		// Token: 0x04005D0C RID: 23820
		private UnknownFieldSet _unknownFields;
	}
}
