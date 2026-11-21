using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0F RID: 2575
	[NetMessage(EMessageId.MotorBattleContextNotify)]
	public sealed class MotorBattleContextNotify : IMessage<MotorBattleContextNotify>, IMessage, IEquatable<MotorBattleContextNotify>, IDeepCloneable<MotorBattleContextNotify>, IBufferMessage
	{
		// Token: 0x0600E193 RID: 57747 RVA: 0x002110C4 File Offset: 0x0020F2C4
		[NullableContext(1)]
		public static MotorBattleContextNotify Create()
		{
			return new MotorBattleContextNotify();
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x0600E194 RID: 57748 RVA: 0x002110CB File Offset: 0x0020F2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x0600E195 RID: 57749 RVA: 0x002110CE File Offset: 0x0020F2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorBattleContextNotify.Descriptor;
			}
		}

		// Token: 0x0600E196 RID: 57750 RVA: 0x002110D5 File Offset: 0x0020F2D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorBattleContextNotify()
		{
		}

		// Token: 0x0600E197 RID: 57751 RVA: 0x002110DD File Offset: 0x0020F2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorBattleContextNotify(MotorBattleContextNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E198 RID: 57752 RVA: 0x002110F6 File Offset: 0x0020F2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorBattleContextNotify Clone()
		{
			return new MotorBattleContextNotify(this);
		}

		// Token: 0x0600E199 RID: 57753 RVA: 0x002110FE File Offset: 0x0020F2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorBattleContextNotify);
		}

		// Token: 0x0600E19A RID: 57754 RVA: 0x0021110C File Offset: 0x0020F30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorBattleContextNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E19B RID: 57755 RVA: 0x0021112C File Offset: 0x0020F32C
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

		// Token: 0x0600E19C RID: 57756 RVA: 0x00211152 File Offset: 0x0020F352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E19D RID: 57757 RVA: 0x0021115F File Offset: 0x0020F35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E19E RID: 57758 RVA: 0x00211168 File Offset: 0x0020F368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E19F RID: 57759 RVA: 0x00211180 File Offset: 0x0020F380
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

		// Token: 0x0600E1A0 RID: 57760 RVA: 0x002111A6 File Offset: 0x0020F3A6
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

		// Token: 0x0600E1A1 RID: 57761 RVA: 0x002111C3 File Offset: 0x0020F3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1A2 RID: 57762 RVA: 0x002111CC File Offset: 0x0020F3CC
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

		// Token: 0x04005D15 RID: 23829
		private UnknownFieldSet _unknownFields;
	}
}
