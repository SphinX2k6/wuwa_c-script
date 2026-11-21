using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBD RID: 3005
	[NetMessage(EMessageId.PassiveSkillAddRequest)]
	public sealed class PassiveSkillAddRequest : IMessage<PassiveSkillAddRequest>, IMessage, IEquatable<PassiveSkillAddRequest>, IDeepCloneable<PassiveSkillAddRequest>, IBufferMessage
	{
		// Token: 0x060104D1 RID: 66769 RVA: 0x002611A4 File Offset: 0x0025F3A4
		[NullableContext(1)]
		public static PassiveSkillAddRequest Create()
		{
			return new PassiveSkillAddRequest();
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x060104D2 RID: 66770 RVA: 0x002611AB File Offset: 0x0025F3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x060104D3 RID: 66771 RVA: 0x002611AE File Offset: 0x0025F3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillAddRequest.Descriptor;
			}
		}

		// Token: 0x060104D4 RID: 66772 RVA: 0x002611B5 File Offset: 0x0025F3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddRequest()
		{
		}

		// Token: 0x060104D5 RID: 66773 RVA: 0x002611BD File Offset: 0x0025F3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddRequest(PassiveSkillAddRequest other) : this()
		{
			this.passiveSkillId_ = other.passiveSkillId_;
			this.targetEntityId_ = other.targetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060104D6 RID: 66774 RVA: 0x002611EE File Offset: 0x0025F3EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddRequest Clone()
		{
			return new PassiveSkillAddRequest(this);
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x060104D7 RID: 66775 RVA: 0x002611F6 File Offset: 0x0025F3F6
		// (set) Token: 0x060104D8 RID: 66776 RVA: 0x002611FE File Offset: 0x0025F3FE
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

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x060104D9 RID: 66777 RVA: 0x00261207 File Offset: 0x0025F407
		// (set) Token: 0x060104DA RID: 66778 RVA: 0x0026120F File Offset: 0x0025F40F
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

		// Token: 0x060104DB RID: 66779 RVA: 0x00261218 File Offset: 0x0025F418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillAddRequest);
		}

		// Token: 0x060104DC RID: 66780 RVA: 0x00261226 File Offset: 0x0025F426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillAddRequest other)
		{
			return other != null && (other == this || (this.PassiveSkillId == other.PassiveSkillId && this.TargetEntityId == other.TargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060104DD RID: 66781 RVA: 0x00261264 File Offset: 0x0025F464
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

		// Token: 0x060104DE RID: 66782 RVA: 0x002612BC File Offset: 0x0025F4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060104DF RID: 66783 RVA: 0x002612C9 File Offset: 0x0025F4C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060104E0 RID: 66784 RVA: 0x002612D4 File Offset: 0x0025F4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PassiveSkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.PassiveSkillId);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060104E1 RID: 66785 RVA: 0x0026132C File Offset: 0x0025F52C
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

		// Token: 0x060104E2 RID: 66786 RVA: 0x00261384 File Offset: 0x0025F584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillAddRequest other)
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

		// Token: 0x060104E3 RID: 66787 RVA: 0x002613D4 File Offset: 0x0025F5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060104E4 RID: 66788 RVA: 0x002613E0 File Offset: 0x0025F5E0
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
				if (num != 8U)
				{
					if (num != 40U)
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

		// Token: 0x040067F9 RID: 26617
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067FA RID: 26618
		public const int PassiveSkillIdFieldNumber = 1;

		// Token: 0x040067FB RID: 26619
		private long passiveSkillId_;

		// Token: 0x040067FC RID: 26620
		public const int TargetEntityIdFieldNumber = 5;

		// Token: 0x040067FD RID: 26621
		private long targetEntityId_;
	}
}
