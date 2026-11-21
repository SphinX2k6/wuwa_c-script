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
		// Token: 0x06001240 RID: 4672 RVA: 0x00032561 File Offset: 0x00030761
		[NullableContext(1)]
		public static AbyssMatchChangeRoleContext Create()
		{
			return new AbyssMatchChangeRoleContext();
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00032568 File Offset: 0x00030768
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
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x0003256B File Offset: 0x0003076B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssMatchChangeRoleContext.Descriptor;
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00032572 File Offset: 0x00030772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchChangeRoleContext()
		{
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00032585 File Offset: 0x00030785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchChangeRoleContext(AbyssMatchChangeRoleContext other) : this()
		{
			this.roleEquipMap_ = other.roleEquipMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x000325AF File Offset: 0x000307AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssMatchChangeRoleContext Clone()
		{
			return new AbyssMatchChangeRoleContext(this);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x000325B7 File Offset: 0x000307B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RoleEquipMap
		{
			get
			{
				return this.roleEquipMap_;
			}
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x000325BF File Offset: 0x000307BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssMatchChangeRoleContext);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000325CD File Offset: 0x000307CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssMatchChangeRoleContext other)
		{
			return other != null && (other == this || (this.RoleEquipMap.Equals(other.RoleEquipMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00032600 File Offset: 0x00030800
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

		// Token: 0x0600124A RID: 4682 RVA: 0x00032634 File Offset: 0x00030834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00032641 File Offset: 0x00030841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0003264A File Offset: 0x0003084A
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

		// Token: 0x0600124D RID: 4685 RVA: 0x00032674 File Offset: 0x00030874
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

		// Token: 0x0600124E RID: 4686 RVA: 0x000326AD File Offset: 0x000308AD
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

		// Token: 0x0600124F RID: 4687 RVA: 0x000326DB File Offset: 0x000308DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x000326E4 File Offset: 0x000308E4
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

		// Token: 0x04002005 RID: 8197
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002006 RID: 8198
		public const int RoleEquipMapFieldNumber = 1;

		// Token: 0x04002007 RID: 8199
		private static readonly MapField<int, int>.Codec _map_roleEquipMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x04002008 RID: 8200
		private readonly MapField<int, int> roleEquipMap_ = new MapField<int, int>();
	}
}
