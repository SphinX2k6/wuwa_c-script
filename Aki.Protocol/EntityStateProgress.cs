using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C3 RID: 1219
	public sealed class EntityStateProgress : IMessage<EntityStateProgress>, IMessage, IEquatable<EntityStateProgress>, IDeepCloneable<EntityStateProgress>, IBufferMessage
	{
		// Token: 0x060073EA RID: 29674 RVA: 0x0011C04F File Offset: 0x0011A24F
		[NullableContext(1)]
		public static EntityStateProgress Create()
		{
			return new EntityStateProgress();
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x060073EB RID: 29675 RVA: 0x0011C056 File Offset: 0x0011A256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x060073EC RID: 29676 RVA: 0x0011C059 File Offset: 0x0011A259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStateProgress.Descriptor;
			}
		}

		// Token: 0x060073ED RID: 29677 RVA: 0x0011C060 File Offset: 0x0011A260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateProgress()
		{
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x0011C073 File Offset: 0x0011A273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateProgress(EntityStateProgress other) : this()
		{
			this.entityId_ = other.entityId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x0011C09D File Offset: 0x0011A29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateProgress Clone()
		{
			return new EntityStateProgress(this);
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x060073F0 RID: 29680 RVA: 0x0011C0A5 File Offset: 0x0011A2A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityId
		{
			get
			{
				return this.entityId_;
			}
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x0011C0AD File Offset: 0x0011A2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStateProgress);
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x0011C0BB File Offset: 0x0011A2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStateProgress other)
		{
			return other != null && (other == this || (this.entityId_.Equals(other.entityId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x0011C0F0 File Offset: 0x0011A2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x0011C124 File Offset: 0x0011A324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x0011C131 File Offset: 0x0011A331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x0011C13A File Offset: 0x0011A33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityId_.WriteTo(ref output, EntityStateProgress._repeated_entityId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x0011C164 File Offset: 0x0011A364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityId_.CalculateSize(EntityStateProgress._repeated_entityId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073F8 RID: 29688 RVA: 0x0011C19D File Offset: 0x0011A39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityStateProgress other)
		{
			if (other == null)
			{
				return;
			}
			this.entityId_.Add(other.entityId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073F9 RID: 29689 RVA: 0x0011C1CB File Offset: 0x0011A3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073FA RID: 29690 RVA: 0x0011C1D4 File Offset: 0x0011A3D4
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityId_.AddEntriesFrom(ref input, EntityStateProgress._repeated_entityId_codec);
				}
			}
		}

		// Token: 0x04003D45 RID: 15685
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D46 RID: 15686
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D47 RID: 15687
		private static readonly FieldCodec<int> _repeated_entityId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003D48 RID: 15688
		private readonly RepeatedField<int> entityId_ = new RepeatedField<int>();
	}
}
