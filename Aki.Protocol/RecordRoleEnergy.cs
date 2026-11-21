using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC4 RID: 3780
	public sealed class RecordRoleEnergy : IMessage<RecordRoleEnergy>, IMessage, IEquatable<RecordRoleEnergy>, IDeepCloneable<RecordRoleEnergy>, IBufferMessage
	{
		// Token: 0x060144A9 RID: 83113 RVA: 0x002F3744 File Offset: 0x002F1944
		[NullableContext(1)]
		public static RecordRoleEnergy Create()
		{
			return new RecordRoleEnergy();
		}

		// Token: 0x17004378 RID: 17272
		// (get) Token: 0x060144AA RID: 83114 RVA: 0x002F374B File Offset: 0x002F194B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecordRoleEnergy> Parser
		{
			get
			{
				return RecordRoleEnergy._parser;
			}
		}

		// Token: 0x17004379 RID: 17273
		// (get) Token: 0x060144AB RID: 83115 RVA: 0x002F3752 File Offset: 0x002F1952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700437A RID: 17274
		// (get) Token: 0x060144AC RID: 83116 RVA: 0x002F3755 File Offset: 0x002F1955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecordRoleEnergy.Descriptor;
			}
		}

		// Token: 0x060144AD RID: 83117 RVA: 0x002F375C File Offset: 0x002F195C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecordRoleEnergy()
		{
		}

		// Token: 0x060144AE RID: 83118 RVA: 0x002F376F File Offset: 0x002F196F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecordRoleEnergy(RecordRoleEnergy other) : this()
		{
			this.levelId_ = other.levelId_;
			this.roleEnergyDict_ = other.roleEnergyDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060144AF RID: 83119 RVA: 0x002F37A5 File Offset: 0x002F19A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecordRoleEnergy Clone()
		{
			return new RecordRoleEnergy(this);
		}

		// Token: 0x1700437B RID: 17275
		// (get) Token: 0x060144B0 RID: 83120 RVA: 0x002F37AD File Offset: 0x002F19AD
		// (set) Token: 0x060144B1 RID: 83121 RVA: 0x002F37B5 File Offset: 0x002F19B5
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

		// Token: 0x1700437C RID: 17276
		// (get) Token: 0x060144B2 RID: 83122 RVA: 0x002F37BE File Offset: 0x002F19BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RoleEnergyDict
		{
			get
			{
				return this.roleEnergyDict_;
			}
		}

		// Token: 0x060144B3 RID: 83123 RVA: 0x002F37C6 File Offset: 0x002F19C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecordRoleEnergy);
		}

		// Token: 0x060144B4 RID: 83124 RVA: 0x002F37D4 File Offset: 0x002F19D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecordRoleEnergy other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.RoleEnergyDict.Equals(other.RoleEnergyDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060144B5 RID: 83125 RVA: 0x002F3824 File Offset: 0x002F1A24
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

		// Token: 0x060144B6 RID: 83126 RVA: 0x002F3871 File Offset: 0x002F1A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060144B7 RID: 83127 RVA: 0x002F387E File Offset: 0x002F1A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060144B8 RID: 83128 RVA: 0x002F3888 File Offset: 0x002F1A88
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

		// Token: 0x060144B9 RID: 83129 RVA: 0x002F38D8 File Offset: 0x002F1AD8
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

		// Token: 0x060144BA RID: 83130 RVA: 0x002F392C File Offset: 0x002F1B2C
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

		// Token: 0x060144BB RID: 83131 RVA: 0x002F3979 File Offset: 0x002F1B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060144BC RID: 83132 RVA: 0x002F3984 File Offset: 0x002F1B84
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

		// Token: 0x04007BAF RID: 31663
		private static readonly MessageParser<RecordRoleEnergy> _parser = new MessageParser<RecordRoleEnergy>(() => new RecordRoleEnergy());

		// Token: 0x04007BB0 RID: 31664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BB1 RID: 31665
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04007BB2 RID: 31666
		private int levelId_;

		// Token: 0x04007BB3 RID: 31667
		public const int RoleEnergyDictFieldNumber = 2;

		// Token: 0x04007BB4 RID: 31668
		private static readonly MapField<int, int>.Codec _map_roleEnergyDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04007BB5 RID: 31669
		private readonly MapField<int, int> roleEnergyDict_ = new MapField<int, int>();
	}
}
