using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009EB RID: 2539
	[NetMessage(EMessageId.ModifyEntityCampNotify)]
	public sealed class ModifyEntityCampNotify : IMessage<ModifyEntityCampNotify>, IMessage, IEquatable<ModifyEntityCampNotify>, IDeepCloneable<ModifyEntityCampNotify>, IBufferMessage
	{
		// Token: 0x0600DE69 RID: 56937 RVA: 0x00209DF9 File Offset: 0x00207FF9
		[NullableContext(1)]
		public static ModifyEntityCampNotify Create()
		{
			return new ModifyEntityCampNotify();
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x0600DE6A RID: 56938 RVA: 0x00209E00 File Offset: 0x00208000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x0600DE6B RID: 56939 RVA: 0x00209E03 File Offset: 0x00208003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyEntityCampNotify.Descriptor;
			}
		}

		// Token: 0x0600DE6C RID: 56940 RVA: 0x00209E0A File Offset: 0x0020800A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyEntityCampNotify()
		{
		}

		// Token: 0x0600DE6D RID: 56941 RVA: 0x00209E12 File Offset: 0x00208012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyEntityCampNotify(ModifyEntityCampNotify other) : this()
		{
			this.targetEntityId_ = other.targetEntityId_;
			this.camp_ = other.camp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE6E RID: 56942 RVA: 0x00209E43 File Offset: 0x00208043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyEntityCampNotify Clone()
		{
			return new ModifyEntityCampNotify(this);
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x0600DE6F RID: 56943 RVA: 0x00209E4B File Offset: 0x0020804B
		// (set) Token: 0x0600DE70 RID: 56944 RVA: 0x00209E53 File Offset: 0x00208053
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

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x0600DE71 RID: 56945 RVA: 0x00209E5C File Offset: 0x0020805C
		// (set) Token: 0x0600DE72 RID: 56946 RVA: 0x00209E64 File Offset: 0x00208064
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

		// Token: 0x0600DE73 RID: 56947 RVA: 0x00209E6D File Offset: 0x0020806D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyEntityCampNotify);
		}

		// Token: 0x0600DE74 RID: 56948 RVA: 0x00209E7B File Offset: 0x0020807B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyEntityCampNotify other)
		{
			return other != null && (other == this || (this.TargetEntityId == other.TargetEntityId && this.Camp == other.Camp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE75 RID: 56949 RVA: 0x00209EBC File Offset: 0x002080BC
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

		// Token: 0x0600DE76 RID: 56950 RVA: 0x00209F14 File Offset: 0x00208114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE77 RID: 56951 RVA: 0x00209F21 File Offset: 0x00208121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE78 RID: 56952 RVA: 0x00209F2C File Offset: 0x0020812C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Camp != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Camp);
			}
			if (this.TargetEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE79 RID: 56953 RVA: 0x00209F88 File Offset: 0x00208188
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

		// Token: 0x0600DE7A RID: 56954 RVA: 0x00209FE0 File Offset: 0x002081E0
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

		// Token: 0x0600DE7B RID: 56955 RVA: 0x0020A030 File Offset: 0x00208230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE7C RID: 56956 RVA: 0x0020A03C File Offset: 0x0020823C
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
				if (num != 48U)
				{
					if (num != 56U)
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

		// Token: 0x04005BD3 RID: 23507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005BD4 RID: 23508
		public const int TargetEntityIdFieldNumber = 7;

		// Token: 0x04005BD5 RID: 23509
		private long targetEntityId_;

		// Token: 0x04005BD6 RID: 23510
		public const int CampFieldNumber = 6;

		// Token: 0x04005BD7 RID: 23511
		private int camp_;
	}
}
