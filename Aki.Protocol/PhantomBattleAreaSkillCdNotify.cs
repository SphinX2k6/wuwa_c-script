using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C17 RID: 3095
	[NetMessage(EMessageId.PhantomBattleAreaSkillCdNotify)]
	public sealed class PhantomBattleAreaSkillCdNotify : IMessage<PhantomBattleAreaSkillCdNotify>, IMessage, IEquatable<PhantomBattleAreaSkillCdNotify>, IDeepCloneable<PhantomBattleAreaSkillCdNotify>, IBufferMessage
	{
		// Token: 0x06010D1E RID: 68894 RVA: 0x002774A7 File Offset: 0x002756A7
		[NullableContext(1)]
		public static PhantomBattleAreaSkillCdNotify Create()
		{
			return new PhantomBattleAreaSkillCdNotify();
		}

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x06010D1F RID: 68895 RVA: 0x002774AE File Offset: 0x002756AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x06010D20 RID: 68896 RVA: 0x002774B1 File Offset: 0x002756B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAreaSkillCdNotify.Descriptor;
			}
		}

		// Token: 0x06010D21 RID: 68897 RVA: 0x002774B8 File Offset: 0x002756B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillCdNotify()
		{
		}

		// Token: 0x06010D22 RID: 68898 RVA: 0x002774C0 File Offset: 0x002756C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillCdNotify(PhantomBattleAreaSkillCdNotify other) : this()
		{
			this.cd_ = other.cd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D23 RID: 68899 RVA: 0x002774E5 File Offset: 0x002756E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillCdNotify Clone()
		{
			return new PhantomBattleAreaSkillCdNotify(this);
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x06010D24 RID: 68900 RVA: 0x002774ED File Offset: 0x002756ED
		// (set) Token: 0x06010D25 RID: 68901 RVA: 0x002774F5 File Offset: 0x002756F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Cd
		{
			get
			{
				return this.cd_;
			}
			set
			{
				this.cd_ = value;
			}
		}

		// Token: 0x06010D26 RID: 68902 RVA: 0x002774FE File Offset: 0x002756FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAreaSkillCdNotify);
		}

		// Token: 0x06010D27 RID: 68903 RVA: 0x0027750C File Offset: 0x0027570C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAreaSkillCdNotify other)
		{
			return other != null && (other == this || (this.Cd == other.Cd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D28 RID: 68904 RVA: 0x0027753C File Offset: 0x0027573C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Cd != 0)
			{
				num ^= this.Cd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010D29 RID: 68905 RVA: 0x0027757B File Offset: 0x0027577B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D2A RID: 68906 RVA: 0x00277588 File Offset: 0x00275788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D2B RID: 68907 RVA: 0x00277591 File Offset: 0x00275791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Cd != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Cd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D2C RID: 68908 RVA: 0x002775C4 File Offset: 0x002757C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Cd != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cd);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010D2D RID: 68909 RVA: 0x00277602 File Offset: 0x00275802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleAreaSkillCdNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Cd != 0)
			{
				this.Cd = other.Cd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010D2E RID: 68910 RVA: 0x00277633 File Offset: 0x00275833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D2F RID: 68911 RVA: 0x0027763C File Offset: 0x0027583C
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
					this.Cd = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B4B RID: 27467
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B4C RID: 27468
		public const int CdFieldNumber = 15;

		// Token: 0x04006B4D RID: 27469
		private int cd_;
	}
}
