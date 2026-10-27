using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200002D RID: 45
	public sealed class AbyssMatchChangeRoleContext : IMessage<AbyssMatchChangeRoleContext>, IMessage, IEquatable<AbyssMatchChangeRoleContext>, IDeepCloneable<AbyssMatchChangeRoleContext>, IBufferMessage
	{
		// Token: 0x06001215 RID: 4629 RVA: 0x00031FAD File Offset: 0x000301AD
		[NullableContext(1)]
		public static AbyssMatchChangeRoleContext Create()
		{
			return new AbyssMatchChangeRoleContext();
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x00031FB4 File Offset: 0x000301B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x00031FB7 File Offset: 0x000301B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssMatchChangeRoleContext.Descriptor;
			}
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00031FBE File Offset: 0x000301BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchChangeRoleContext()
		{
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00031FD1 File Offset: 0x000301D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchChangeRoleContext(AbyssMatchChangeRoleContext other) : this()
		{
			this.roleEquipMap_ = other.roleEquipMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00031FFB File Offset: 0x000301FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchChangeRoleContext Clone()
		{
			return new AbyssMatchChangeRoleContext(this);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x00032003 File Offset: 0x00030203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RoleEquipMap
		{
			get
			{
				return this.roleEquipMap_;
			}
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0003200B File Offset: 0x0003020B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssMatchChangeRoleContext);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00032019 File Offset: 0x00030219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssMatchChangeRoleContext other)
		{
			return other != null && (other == this || (this.RoleEquipMap.Equals(other.RoleEquipMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0003204C File Offset: 0x0003024C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.RoleEquipMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00032080 File Offset: 0x00030280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0003208D File Offset: 0x0003028D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00032096 File Offset: 0x00030296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleEquipMap_.WriteTo(ref output, AbyssMatchChangeRoleContext._map_roleEquipMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x000320C0 File Offset: 0x000302C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleEquipMap_.CalculateSize(AbyssMatchChangeRoleContext._map_roleEquipMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x000320F9 File Offset: 0x000302F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssMatchChangeRoleContext other)
		{
			if (other == null)
			{
				return;
			}
			this.roleEquipMap_.MergeFrom(other.roleEquipMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00032127 File Offset: 0x00030327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00032130 File Offset: 0x00030330
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
					this.roleEquipMap_.AddEntriesFrom(ref input, AbyssMatchChangeRoleContext._map_roleEquipMap_codec);
				}
			}
		}

		// Token: 0x04001FAF RID: 8111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FB0 RID: 8112
		public const int RoleEquipMapFieldNumber = 1;

		// Token: 0x04001FB1 RID: 8113
		private static readonly MapField<int, int>.Codec _map_roleEquipMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04001FB2 RID: 8114
		private readonly MapField<int, int> roleEquipMap_ = new MapField<int, int>();
	}
}
