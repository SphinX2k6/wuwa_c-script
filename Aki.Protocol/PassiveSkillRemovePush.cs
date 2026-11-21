using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC4 RID: 3012
	[NetMessage(EMessageId.PassiveSkillRemovePush)]
	public sealed class PassiveSkillRemovePush : IMessage<PassiveSkillRemovePush>, IMessage, IEquatable<PassiveSkillRemovePush>, IDeepCloneable<PassiveSkillRemovePush>, IBufferMessage
	{
		// Token: 0x0601055B RID: 66907 RVA: 0x0026224C File Offset: 0x0026044C
		[NullableContext(1)]
		public static PassiveSkillRemovePush Create()
		{
			return new PassiveSkillRemovePush();
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0601055C RID: 66908 RVA: 0x00262253 File Offset: 0x00260453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0601055D RID: 66909 RVA: 0x00262256 File Offset: 0x00260456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillRemovePush.Descriptor;
			}
		}

		// Token: 0x0601055E RID: 66910 RVA: 0x0026225D File Offset: 0x0026045D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemovePush()
		{
		}

		// Token: 0x0601055F RID: 66911 RVA: 0x00262265 File Offset: 0x00260465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemovePush(PassiveSkillRemovePush other) : this()
		{
			this.passiveSkillId_ = other.passiveSkillId_;
			this.targetEntityId_ = other.targetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010560 RID: 66912 RVA: 0x00262296 File Offset: 0x00260496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillRemovePush Clone()
		{
			return new PassiveSkillRemovePush(this);
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x06010561 RID: 66913 RVA: 0x0026229E File Offset: 0x0026049E
		// (set) Token: 0x06010562 RID: 66914 RVA: 0x002622A6 File Offset: 0x002604A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PassiveSkillId
		{
			get
			{
				return this.passiveSkillId_;
			}
			set
			{
				this.passiveSkillId_ = value;
			}
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x06010563 RID: 66915 RVA: 0x002622AF File Offset: 0x002604AF
		// (set) Token: 0x06010564 RID: 66916 RVA: 0x002622B7 File Offset: 0x002604B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntityId
		{
			get
			{
				return this.targetEntityId_;
			}
			set
			{
				this.targetEntityId_ = value;
			}
		}

		// Token: 0x06010565 RID: 66917 RVA: 0x002622C0 File Offset: 0x002604C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillRemovePush);
		}

		// Token: 0x06010566 RID: 66918 RVA: 0x002622CE File Offset: 0x002604CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillRemovePush other)
		{
			return other != null && (other == this || (this.PassiveSkillId == other.PassiveSkillId && this.TargetEntityId == other.TargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010567 RID: 66919 RVA: 0x0026230C File Offset: 0x0026050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PassiveSkillId != 0L)
			{
				num ^= this.PassiveSkillId.GetHashCode();
			}
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010568 RID: 66920 RVA: 0x00262364 File Offset: 0x00260564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010569 RID: 66921 RVA: 0x00262371 File Offset: 0x00260571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601056A RID: 66922 RVA: 0x0026237C File Offset: 0x0026057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PassiveSkillId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.PassiveSkillId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601056B RID: 66923 RVA: 0x002623D8 File Offset: 0x002605D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PassiveSkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PassiveSkillId);
			}
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601056C RID: 66924 RVA: 0x00262430 File Offset: 0x00260630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillRemovePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PassiveSkillId != 0L)
			{
				this.PassiveSkillId = other.PassiveSkillId;
			}
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601056D RID: 66925 RVA: 0x00262480 File Offset: 0x00260680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601056E RID: 66926 RVA: 0x0026248C File Offset: 0x0026068C
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
				if (num != 64U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.PassiveSkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400681B RID: 26651
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400681C RID: 26652
		public const int PassiveSkillIdFieldNumber = 8;

		// Token: 0x0400681D RID: 26653
		private long passiveSkillId_;

		// Token: 0x0400681E RID: 26654
		public const int TargetEntityIdFieldNumber = 9;

		// Token: 0x0400681F RID: 26655
		private long targetEntityId_;
	}
}
