using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED4 RID: 3796
	public sealed class RecordRoleEnergy : IMessage<RecordRoleEnergy>, IMessage, IEquatable<RecordRoleEnergy>, IDeepCloneable<RecordRoleEnergy>, IBufferMessage
	{
		// Token: 0x0601458E RID: 83342 RVA: 0x002F4DF8 File Offset: 0x002F2FF8
		[NullableContext(1)]
		public static RecordRoleEnergy Create()
		{
			return new RecordRoleEnergy();
		}

		// Token: 0x170043A2 RID: 17314
		// (get) Token: 0x0601458F RID: 83343 RVA: 0x002F4DFF File Offset: 0x002F2FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecordRoleEnergy> Parser
		{
			get
			{
				return RecordRoleEnergy._parser;
			}
		}

		// Token: 0x170043A3 RID: 17315
		// (get) Token: 0x06014590 RID: 83344 RVA: 0x002F4E06 File Offset: 0x002F3006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043A4 RID: 17316
		// (get) Token: 0x06014591 RID: 83345 RVA: 0x002F4E09 File Offset: 0x002F3009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecordRoleEnergy.Descriptor;
			}
		}

		// Token: 0x06014592 RID: 83346 RVA: 0x002F4E10 File Offset: 0x002F3010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecordRoleEnergy()
		{
		}

		// Token: 0x06014593 RID: 83347 RVA: 0x002F4E23 File Offset: 0x002F3023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecordRoleEnergy(RecordRoleEnergy other) : this()
		{
			this.levelId_ = other.levelId_;
			this.roleEnergyDict_ = other.roleEnergyDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014594 RID: 83348 RVA: 0x002F4E59 File Offset: 0x002F3059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecordRoleEnergy Clone()
		{
			return new RecordRoleEnergy(this);
		}

		// Token: 0x170043A5 RID: 17317
		// (get) Token: 0x06014595 RID: 83349 RVA: 0x002F4E61 File Offset: 0x002F3061
		// (set) Token: 0x06014596 RID: 83350 RVA: 0x002F4E69 File Offset: 0x002F3069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170043A6 RID: 17318
		// (get) Token: 0x06014597 RID: 83351 RVA: 0x002F4E72 File Offset: 0x002F3072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RoleEnergyDict
		{
			get
			{
				return this.roleEnergyDict_;
			}
		}

		// Token: 0x06014598 RID: 83352 RVA: 0x002F4E7A File Offset: 0x002F307A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecordRoleEnergy);
		}

		// Token: 0x06014599 RID: 83353 RVA: 0x002F4E88 File Offset: 0x002F3088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecordRoleEnergy other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.RoleEnergyDict.Equals(other.RoleEnergyDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601459A RID: 83354 RVA: 0x002F4ED8 File Offset: 0x002F30D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.RoleEnergyDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601459B RID: 83355 RVA: 0x002F4F25 File Offset: 0x002F3125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601459C RID: 83356 RVA: 0x002F4F32 File Offset: 0x002F3132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601459D RID: 83357 RVA: 0x002F4F3C File Offset: 0x002F313C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			this.roleEnergyDict_.WriteTo(ref output, RecordRoleEnergy._map_roleEnergyDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601459E RID: 83358 RVA: 0x002F4F8C File Offset: 0x002F318C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.roleEnergyDict_.CalculateSize(RecordRoleEnergy._map_roleEnergyDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601459F RID: 83359 RVA: 0x002F4FE0 File Offset: 0x002F31E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecordRoleEnergy other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.roleEnergyDict_.MergeFrom(other.roleEnergyDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060145A0 RID: 83360 RVA: 0x002F502D File Offset: 0x002F322D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145A1 RID: 83361 RVA: 0x002F5038 File Offset: 0x002F3238
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleEnergyDict_.AddEntriesFrom(ref input, RecordRoleEnergy._map_roleEnergyDict_codec);
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B85 RID: 31621
		private static readonly MessageParser<RecordRoleEnergy> _parser = new MessageParser<RecordRoleEnergy>(() => new RecordRoleEnergy());

		// Token: 0x04007B86 RID: 31622
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B87 RID: 31623
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04007B88 RID: 31624
		private int levelId_;

		// Token: 0x04007B89 RID: 31625
		public const int RoleEnergyDictFieldNumber = 2;

		// Token: 0x04007B8A RID: 31626
		private static readonly MapField<int, int>.Codec _map_roleEnergyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04007B8B RID: 31627
		private readonly MapField<int, int> roleEnergyDict_ = new MapField<int, int>();
	}
}
