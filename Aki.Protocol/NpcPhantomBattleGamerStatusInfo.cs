using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B65 RID: 2917
	public sealed class NpcPhantomBattleGamerStatusInfo : IMessage<NpcPhantomBattleGamerStatusInfo>, IMessage, IEquatable<NpcPhantomBattleGamerStatusInfo>, IDeepCloneable<NpcPhantomBattleGamerStatusInfo>, IBufferMessage
	{
		// Token: 0x0600FD3C RID: 64828 RVA: 0x0024F78D File Offset: 0x0024D98D
		[NullableContext(1)]
		public static NpcPhantomBattleGamerStatusInfo Create()
		{
			return new NpcPhantomBattleGamerStatusInfo();
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0600FD3D RID: 64829 RVA: 0x0024F794 File Offset: 0x0024D994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0600FD3E RID: 64830 RVA: 0x0024F797 File Offset: 0x0024D997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleGamerStatusInfo.Descriptor;
			}
		}

		// Token: 0x0600FD3F RID: 64831 RVA: 0x0024F79E File Offset: 0x0024D99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleGamerStatusInfo()
		{
		}

		// Token: 0x0600FD40 RID: 64832 RVA: 0x0024F7B1 File Offset: 0x0024D9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleGamerStatusInfo(NpcPhantomBattleGamerStatusInfo other) : this()
		{
			this.gamerIndex_ = other.gamerIndex_;
			this.battleStatus_ = other.battleStatus_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD41 RID: 64833 RVA: 0x0024F7E7 File Offset: 0x0024D9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleGamerStatusInfo Clone()
		{
			return new NpcPhantomBattleGamerStatusInfo(this);
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600FD42 RID: 64834 RVA: 0x0024F7EF File Offset: 0x0024D9EF
		// (set) Token: 0x0600FD43 RID: 64835 RVA: 0x0024F7F7 File Offset: 0x0024D9F7
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

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600FD44 RID: 64836 RVA: 0x0024F800 File Offset: 0x0024DA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BattleStatus
		{
			get
			{
				return this.battleStatus_;
			}
		}

		// Token: 0x0600FD45 RID: 64837 RVA: 0x0024F808 File Offset: 0x0024DA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleGamerStatusInfo);
		}

		// Token: 0x0600FD46 RID: 64838 RVA: 0x0024F818 File Offset: 0x0024DA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleGamerStatusInfo other)
		{
			return other != null && (other == this || (this.GamerIndex == other.GamerIndex && this.BattleStatus.Equals(other.BattleStatus) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD47 RID: 64839 RVA: 0x0024F868 File Offset: 0x0024DA68
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

		// Token: 0x0600FD48 RID: 64840 RVA: 0x0024F8B5 File Offset: 0x0024DAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD49 RID: 64841 RVA: 0x0024F8C2 File Offset: 0x0024DAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD4A RID: 64842 RVA: 0x0024F8CC File Offset: 0x0024DACC
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

		// Token: 0x0600FD4B RID: 64843 RVA: 0x0024F91C File Offset: 0x0024DB1C
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

		// Token: 0x0600FD4C RID: 64844 RVA: 0x0024F970 File Offset: 0x0024DB70
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

		// Token: 0x0600FD4D RID: 64845 RVA: 0x0024F9BD File Offset: 0x0024DBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD4E RID: 64846 RVA: 0x0024F9C8 File Offset: 0x0024DBC8
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

		// Token: 0x04006570 RID: 25968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006571 RID: 25969
		public const int GamerIndexFieldNumber = 1;

		// Token: 0x04006572 RID: 25970
		private int gamerIndex_;

		// Token: 0x04006573 RID: 25971
		public const int BattleStatusFieldNumber = 2;

		// Token: 0x04006574 RID: 25972
		private static readonly MapField<int, int>.Codec _map_battleStatus_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x04006575 RID: 25973
		private readonly MapField<int, int> battleStatus_ = new MapField<int, int>();
	}
}
