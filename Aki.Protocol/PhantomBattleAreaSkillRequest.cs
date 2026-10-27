using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C29 RID: 3113
	[NetMessage(EMessageId.PhantomBattleAreaSkillRequest)]
	public sealed class PhantomBattleAreaSkillRequest : IMessage<PhantomBattleAreaSkillRequest>, IMessage, IEquatable<PhantomBattleAreaSkillRequest>, IDeepCloneable<PhantomBattleAreaSkillRequest>, IBufferMessage
	{
		// Token: 0x06010E42 RID: 69186 RVA: 0x0027960C File Offset: 0x0027780C
		[NullableContext(1)]
		public static PhantomBattleAreaSkillRequest Create()
		{
			return new PhantomBattleAreaSkillRequest();
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x06010E43 RID: 69187 RVA: 0x00279613 File Offset: 0x00277813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x06010E44 RID: 69188 RVA: 0x00279616 File Offset: 0x00277816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAreaSkillRequest.Descriptor;
			}
		}

		// Token: 0x06010E45 RID: 69189 RVA: 0x0027961D File Offset: 0x0027781D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillRequest()
		{
		}

		// Token: 0x06010E46 RID: 69190 RVA: 0x00279625 File Offset: 0x00277825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillRequest(PhantomBattleAreaSkillRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E47 RID: 69191 RVA: 0x0027963E File Offset: 0x0027783E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillRequest Clone()
		{
			return new PhantomBattleAreaSkillRequest(this);
		}

		// Token: 0x06010E48 RID: 69192 RVA: 0x00279646 File Offset: 0x00277846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAreaSkillRequest);
		}

		// Token: 0x06010E49 RID: 69193 RVA: 0x00279654 File Offset: 0x00277854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAreaSkillRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010E4A RID: 69194 RVA: 0x00279674 File Offset: 0x00277874
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

		// Token: 0x06010E4B RID: 69195 RVA: 0x0027969A File Offset: 0x0027789A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E4C RID: 69196 RVA: 0x002796A7 File Offset: 0x002778A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E4D RID: 69197 RVA: 0x002796B0 File Offset: 0x002778B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E4E RID: 69198 RVA: 0x002796C8 File Offset: 0x002778C8
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

		// Token: 0x06010E4F RID: 69199 RVA: 0x002796EE File Offset: 0x002778EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleAreaSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010E50 RID: 69200 RVA: 0x0027970B File Offset: 0x0027790B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E51 RID: 69201 RVA: 0x00279714 File Offset: 0x00277914
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

		// Token: 0x04006B3D RID: 27453
		private UnknownFieldSet _unknownFields;
	}
}
