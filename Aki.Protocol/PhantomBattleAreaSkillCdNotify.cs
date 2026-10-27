using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C27 RID: 3111
	[NetMessage(EMessageId.PhantomBattleAreaSkillCdNotify)]
	public sealed class PhantomBattleAreaSkillCdNotify : IMessage<PhantomBattleAreaSkillCdNotify>, IMessage, IEquatable<PhantomBattleAreaSkillCdNotify>, IDeepCloneable<PhantomBattleAreaSkillCdNotify>, IBufferMessage
	{
		// Token: 0x06010E1E RID: 69150 RVA: 0x0027920B File Offset: 0x0027740B
		[NullableContext(1)]
		public static PhantomBattleAreaSkillCdNotify Create()
		{
			return new PhantomBattleAreaSkillCdNotify();
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x06010E1F RID: 69151 RVA: 0x00279212 File Offset: 0x00277412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x06010E20 RID: 69152 RVA: 0x00279215 File Offset: 0x00277415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAreaSkillCdNotify.Descriptor;
			}
		}

		// Token: 0x06010E21 RID: 69153 RVA: 0x0027921C File Offset: 0x0027741C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillCdNotify()
		{
		}

		// Token: 0x06010E22 RID: 69154 RVA: 0x00279224 File Offset: 0x00277424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillCdNotify(PhantomBattleAreaSkillCdNotify other) : this()
		{
			this.cd_ = other.cd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E23 RID: 69155 RVA: 0x00279249 File Offset: 0x00277449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillCdNotify Clone()
		{
			return new PhantomBattleAreaSkillCdNotify(this);
		}

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x06010E24 RID: 69156 RVA: 0x00279251 File Offset: 0x00277451
		// (set) Token: 0x06010E25 RID: 69157 RVA: 0x00279259 File Offset: 0x00277459
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

		// Token: 0x06010E26 RID: 69158 RVA: 0x00279262 File Offset: 0x00277462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAreaSkillCdNotify);
		}

		// Token: 0x06010E27 RID: 69159 RVA: 0x00279270 File Offset: 0x00277470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAreaSkillCdNotify other)
		{
			return other != null && (other == this || (this.Cd == other.Cd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E28 RID: 69160 RVA: 0x002792A0 File Offset: 0x002774A0
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

		// Token: 0x06010E29 RID: 69161 RVA: 0x002792DF File Offset: 0x002774DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E2A RID: 69162 RVA: 0x002792EC File Offset: 0x002774EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E2B RID: 69163 RVA: 0x002792F5 File Offset: 0x002774F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Cd != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Cd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E2C RID: 69164 RVA: 0x00279328 File Offset: 0x00277528
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

		// Token: 0x06010E2D RID: 69165 RVA: 0x00279366 File Offset: 0x00277566
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

		// Token: 0x06010E2E RID: 69166 RVA: 0x00279397 File Offset: 0x00277597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E2F RID: 69167 RVA: 0x002793A0 File Offset: 0x002775A0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Cd = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B37 RID: 27447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B38 RID: 27448
		public const int CdFieldNumber = 9;

		// Token: 0x04006B39 RID: 27449
		private int cd_;
	}
}
