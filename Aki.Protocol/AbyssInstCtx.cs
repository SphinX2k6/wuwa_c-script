using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000026 RID: 38
	public sealed class AbyssInstCtx : IMessage<AbyssInstCtx>, IMessage, IEquatable<AbyssInstCtx>, IDeepCloneable<AbyssInstCtx>, IBufferMessage
	{
		// Token: 0x060011B9 RID: 4537 RVA: 0x00031521 File Offset: 0x0002F721
		[NullableContext(1)]
		public static AbyssInstCtx Create()
		{
			return new AbyssInstCtx();
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x00031528 File Offset: 0x0002F728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x0003152B File Offset: 0x0002F72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssInstCtx.Descriptor;
			}
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00031532 File Offset: 0x0002F732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInstCtx()
		{
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00031545 File Offset: 0x0002F745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInstCtx(AbyssInstCtx other) : this()
		{
			this.littleRoleMap_ = other.littleRoleMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0003156F File Offset: 0x0002F76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssInstCtx Clone()
		{
			return new AbyssInstCtx(this);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x00031577 File Offset: 0x0002F777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LittleRoleMap
		{
			get
			{
				return this.littleRoleMap_;
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0003157F File Offset: 0x0002F77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssInstCtx);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0003158D File Offset: 0x0002F78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssInstCtx other)
		{
			return other != null && (other == this || (this.LittleRoleMap.Equals(other.LittleRoleMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x000315C0 File Offset: 0x0002F7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.LittleRoleMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x000315F4 File Offset: 0x0002F7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00031601 File Offset: 0x0002F801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0003160A File Offset: 0x0002F80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.littleRoleMap_.WriteTo(ref output, AbyssInstCtx._map_littleRoleMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00031634 File Offset: 0x0002F834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.littleRoleMap_.CalculateSize(AbyssInstCtx._map_littleRoleMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0003166D File Offset: 0x0002F86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssInstCtx other)
		{
			if (other == null)
			{
				return;
			}
			this.littleRoleMap_.MergeFrom(other.littleRoleMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0003169B File Offset: 0x0002F89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x000316A4 File Offset: 0x0002F8A4
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.littleRoleMap_.AddEntriesFrom(ref input, AbyssInstCtx._map_littleRoleMap_codec);
				}
			}
		}

		// Token: 0x04001FE4 RID: 8164
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FE5 RID: 8165
		public const int LittleRoleMapFieldNumber = 1;

		// Token: 0x04001FE6 RID: 8166
		private static readonly MapField<int, int>.Codec _map_littleRoleMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04001FE7 RID: 8167
		private readonly MapField<int, int> littleRoleMap_ = new MapField<int, int>();
	}
}
