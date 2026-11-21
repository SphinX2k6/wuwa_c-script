using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C19 RID: 3097
	[NetMessage(EMessageId.PhantomBattleAreaSkillRequest)]
	public sealed class PhantomBattleAreaSkillRequest : IMessage<PhantomBattleAreaSkillRequest>, IMessage, IEquatable<PhantomBattleAreaSkillRequest>, IDeepCloneable<PhantomBattleAreaSkillRequest>, IBufferMessage
	{
		// Token: 0x06010D42 RID: 68930 RVA: 0x002778A8 File Offset: 0x00275AA8
		[NullableContext(1)]
		public static PhantomBattleAreaSkillRequest Create()
		{
			return new PhantomBattleAreaSkillRequest();
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x06010D43 RID: 68931 RVA: 0x002778AF File Offset: 0x00275AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x06010D44 RID: 68932 RVA: 0x002778B2 File Offset: 0x00275AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAreaSkillRequest.Descriptor;
			}
		}

		// Token: 0x06010D45 RID: 68933 RVA: 0x002778B9 File Offset: 0x00275AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillRequest()
		{
		}

		// Token: 0x06010D46 RID: 68934 RVA: 0x002778C1 File Offset: 0x00275AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillRequest(PhantomBattleAreaSkillRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D47 RID: 68935 RVA: 0x002778DA File Offset: 0x00275ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillRequest Clone()
		{
			return new PhantomBattleAreaSkillRequest(this);
		}

		// Token: 0x06010D48 RID: 68936 RVA: 0x002778E2 File Offset: 0x00275AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAreaSkillRequest);
		}

		// Token: 0x06010D49 RID: 68937 RVA: 0x002778F0 File Offset: 0x00275AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAreaSkillRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06010D4A RID: 68938 RVA: 0x00277910 File Offset: 0x00275B10
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

		// Token: 0x06010D4B RID: 68939 RVA: 0x00277936 File Offset: 0x00275B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D4C RID: 68940 RVA: 0x00277943 File Offset: 0x00275B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D4D RID: 68941 RVA: 0x0027794C File Offset: 0x00275B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D4E RID: 68942 RVA: 0x00277964 File Offset: 0x00275B64
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

		// Token: 0x06010D4F RID: 68943 RVA: 0x0027798A File Offset: 0x00275B8A
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

		// Token: 0x06010D50 RID: 68944 RVA: 0x002779A7 File Offset: 0x00275BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D51 RID: 68945 RVA: 0x002779B0 File Offset: 0x00275BB0
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

		// Token: 0x04006B51 RID: 27473
		private UnknownFieldSet _unknownFields;
	}
}
