using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DA RID: 2522
	[NetMessage(EMessageId.ModifyEntityCampNotify)]
	public sealed class ModifyEntityCampNotify : IMessage<ModifyEntityCampNotify>, IMessage, IEquatable<ModifyEntityCampNotify>, IDeepCloneable<ModifyEntityCampNotify>, IBufferMessage
	{
		// Token: 0x0600DD4F RID: 56655 RVA: 0x00207C0D File Offset: 0x00205E0D
		[NullableContext(1)]
		public static ModifyEntityCampNotify Create()
		{
			return new ModifyEntityCampNotify();
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x0600DD50 RID: 56656 RVA: 0x00207C14 File Offset: 0x00205E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x0600DD51 RID: 56657 RVA: 0x00207C17 File Offset: 0x00205E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyEntityCampNotify.Descriptor;
			}
		}

		// Token: 0x0600DD52 RID: 56658 RVA: 0x00207C1E File Offset: 0x00205E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyEntityCampNotify()
		{
		}

		// Token: 0x0600DD53 RID: 56659 RVA: 0x00207C26 File Offset: 0x00205E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyEntityCampNotify(ModifyEntityCampNotify other) : this()
		{
			this.targetEntityId_ = other.targetEntityId_;
			this.camp_ = other.camp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD54 RID: 56660 RVA: 0x00207C57 File Offset: 0x00205E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyEntityCampNotify Clone()
		{
			return new ModifyEntityCampNotify(this);
		}

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x0600DD55 RID: 56661 RVA: 0x00207C5F File Offset: 0x00205E5F
		// (set) Token: 0x0600DD56 RID: 56662 RVA: 0x00207C67 File Offset: 0x00205E67
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

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x0600DD57 RID: 56663 RVA: 0x00207C70 File Offset: 0x00205E70
		// (set) Token: 0x0600DD58 RID: 56664 RVA: 0x00207C78 File Offset: 0x00205E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Camp
		{
			get
			{
				return this.camp_;
			}
			set
			{
				this.camp_ = value;
			}
		}

		// Token: 0x0600DD59 RID: 56665 RVA: 0x00207C81 File Offset: 0x00205E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyEntityCampNotify);
		}

		// Token: 0x0600DD5A RID: 56666 RVA: 0x00207C8F File Offset: 0x00205E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyEntityCampNotify other)
		{
			return other != null && (other == this || (this.TargetEntityId == other.TargetEntityId && this.Camp == other.Camp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD5B RID: 56667 RVA: 0x00207CD0 File Offset: 0x00205ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetEntityId != 0L)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.Camp != 0)
			{
				num ^= this.Camp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD5C RID: 56668 RVA: 0x00207D28 File Offset: 0x00205F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD5D RID: 56669 RVA: 0x00207D35 File Offset: 0x00205F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD5E RID: 56670 RVA: 0x00207D40 File Offset: 0x00205F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Camp != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Camp);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD5F RID: 56671 RVA: 0x00207D9C File Offset: 0x00205F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this.Camp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Camp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD60 RID: 56672 RVA: 0x00207DF4 File Offset: 0x00205FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyEntityCampNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetEntityId != 0L)
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			if (other.Camp != 0)
			{
				this.Camp = other.Camp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD61 RID: 56673 RVA: 0x00207E44 File Offset: 0x00206044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD62 RID: 56674 RVA: 0x00207E50 File Offset: 0x00206050
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
					if (num != 96U)
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
					this.Camp = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005BDC RID: 23516
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BDD RID: 23517
		public const int TargetEntityIdFieldNumber = 12;

		// Token: 0x04005BDE RID: 23518
		private long targetEntityId_;

		// Token: 0x04005BDF RID: 23519
		public const int CampFieldNumber = 9;

		// Token: 0x04005BE0 RID: 23520
		private int camp_;
	}
}
