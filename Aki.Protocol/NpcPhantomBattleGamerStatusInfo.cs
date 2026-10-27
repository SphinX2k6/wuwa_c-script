using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B75 RID: 2933
	public sealed class NpcPhantomBattleGamerStatusInfo : IMessage<NpcPhantomBattleGamerStatusInfo>, IMessage, IEquatable<NpcPhantomBattleGamerStatusInfo>, IDeepCloneable<NpcPhantomBattleGamerStatusInfo>, IBufferMessage
	{
		// Token: 0x0600FE40 RID: 65088 RVA: 0x0025165D File Offset: 0x0024F85D
		[NullableContext(1)]
		public static NpcPhantomBattleGamerStatusInfo Create()
		{
			return new NpcPhantomBattleGamerStatusInfo();
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600FE41 RID: 65089 RVA: 0x00251664 File Offset: 0x0024F864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600FE42 RID: 65090 RVA: 0x00251667 File Offset: 0x0024F867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleGamerStatusInfo.Descriptor;
			}
		}

		// Token: 0x0600FE43 RID: 65091 RVA: 0x0025166E File Offset: 0x0024F86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleGamerStatusInfo()
		{
		}

		// Token: 0x0600FE44 RID: 65092 RVA: 0x00251681 File Offset: 0x0024F881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleGamerStatusInfo(NpcPhantomBattleGamerStatusInfo other) : this()
		{
			this.gamerIndex_ = other.gamerIndex_;
			this.battleStatus_ = other.battleStatus_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE45 RID: 65093 RVA: 0x002516B7 File Offset: 0x0024F8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleGamerStatusInfo Clone()
		{
			return new NpcPhantomBattleGamerStatusInfo(this);
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600FE46 RID: 65094 RVA: 0x002516BF File Offset: 0x0024F8BF
		// (set) Token: 0x0600FE47 RID: 65095 RVA: 0x002516C7 File Offset: 0x0024F8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamerIndex
		{
			get
			{
				return this.gamerIndex_;
			}
			set
			{
				this.gamerIndex_ = value;
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600FE48 RID: 65096 RVA: 0x002516D0 File Offset: 0x0024F8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleStatus
		{
			get
			{
				return this.battleStatus_;
			}
		}

		// Token: 0x0600FE49 RID: 65097 RVA: 0x002516D8 File Offset: 0x0024F8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleGamerStatusInfo);
		}

		// Token: 0x0600FE4A RID: 65098 RVA: 0x002516E8 File Offset: 0x0024F8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleGamerStatusInfo other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.BattleStatus.Equals(other.BattleStatus) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE4B RID: 65099 RVA: 0x00251738 File Offset: 0x0024F938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamerIndex != 0)
			{
				num ^= this.GamerIndex.GetHashCode();
			}
			num ^= this.BattleStatus.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FE4C RID: 65100 RVA: 0x00251785 File Offset: 0x0024F985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE4D RID: 65101 RVA: 0x00251792 File Offset: 0x0024F992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE4E RID: 65102 RVA: 0x0025179C File Offset: 0x0024F99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamerIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GamerIndex);
			}
			this.battleStatus_.WriteTo(ref output, NpcPhantomBattleGamerStatusInfo._map_battleStatus_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FE4F RID: 65103 RVA: 0x002517EC File Offset: 0x0024F9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamerIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamerIndex);
			}
			num += this.battleStatus_.CalculateSize(NpcPhantomBattleGamerStatusInfo._map_battleStatus_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FE50 RID: 65104 RVA: 0x00251840 File Offset: 0x0024FA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleGamerStatusInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamerIndex != 0)
			{
				this.GamerIndex = other.GamerIndex;
			}
			this.battleStatus_.MergeFrom(other.battleStatus_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FE51 RID: 65105 RVA: 0x0025188D File Offset: 0x0024FA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE52 RID: 65106 RVA: 0x00251898 File Offset: 0x0024FA98
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
						this.battleStatus_.AddEntriesFrom(ref input, NpcPhantomBattleGamerStatusInfo._map_battleStatus_codec);
					}
				}
				else
				{
					this.GamerIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006560 RID: 25952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006561 RID: 25953
		public const int GamerIndexFieldNumber = 1;

		// Token: 0x04006562 RID: 25954
		private int gamerIndex_;

		// Token: 0x04006563 RID: 25955
		public const int BattleStatusFieldNumber = 2;

		// Token: 0x04006564 RID: 25956
		private static readonly MapField<int, int>.Codec _map_battleStatus_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04006565 RID: 25957
		private readonly MapField<int, int> battleStatus_ = new MapField<int, int>();
	}
}
