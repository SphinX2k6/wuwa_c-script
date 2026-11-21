using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001594 RID: 5524
	public sealed class WorldTeamPlayerFightInfo : IMessage<WorldTeamPlayerFightInfo>, IMessage, IEquatable<WorldTeamPlayerFightInfo>, IDeepCloneable<WorldTeamPlayerFightInfo>, IBufferMessage
	{
		// Token: 0x0601D3CA RID: 119754 RVA: 0x0043B5B4 File Offset: 0x004397B4
		[NullableContext(1)]
		public static WorldTeamPlayerFightInfo Create()
		{
			return new WorldTeamPlayerFightInfo();
		}

		// Token: 0x170062E5 RID: 25317
		// (get) Token: 0x0601D3CB RID: 119755 RVA: 0x0043B5BB File Offset: 0x004397BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062E6 RID: 25318
		// (get) Token: 0x0601D3CC RID: 119756 RVA: 0x0043B5BE File Offset: 0x004397BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldTeamPlayerFightInfo.Descriptor;
			}
		}

		// Token: 0x0601D3CD RID: 119757 RVA: 0x0043B5C5 File Offset: 0x004397C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerFightInfo()
		{
		}

		// Token: 0x0601D3CE RID: 119758 RVA: 0x0043B5D8 File Offset: 0x004397D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerFightInfo(WorldTeamPlayerFightInfo other) : this()
		{
			this.curRoleId_ = other.curRoleId_;
			this.roleInfos_ = other.roleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D3CF RID: 119759 RVA: 0x0043B60E File Offset: 0x0043980E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerFightInfo Clone()
		{
			return new WorldTeamPlayerFightInfo(this);
		}

		// Token: 0x170062E7 RID: 25319
		// (get) Token: 0x0601D3D0 RID: 119760 RVA: 0x0043B616 File Offset: 0x00439816
		// (set) Token: 0x0601D3D1 RID: 119761 RVA: 0x0043B61E File Offset: 0x0043981E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRoleId
		{
			get
			{
				return this.curRoleId_;
			}
			set
			{
				this.curRoleId_ = value;
			}
		}

		// Token: 0x170062E8 RID: 25320
		// (get) Token: 0x0601D3D2 RID: 119762 RVA: 0x0043B627 File Offset: 0x00439827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WorldTeamRoleInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x0601D3D3 RID: 119763 RVA: 0x0043B62F File Offset: 0x0043982F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldTeamPlayerFightInfo);
		}

		// Token: 0x0601D3D4 RID: 119764 RVA: 0x0043B640 File Offset: 0x00439840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldTeamPlayerFightInfo other)
		{
			return other != null && (other == this || (this.CurRoleId == other.CurRoleId && this.roleInfos_.Equals(other.roleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D3D5 RID: 119765 RVA: 0x0043B690 File Offset: 0x00439890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurRoleId != 0)
			{
				num ^= this.CurRoleId.GetHashCode();
			}
			num ^= this.roleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D3D6 RID: 119766 RVA: 0x0043B6DD File Offset: 0x004398DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D3D7 RID: 119767 RVA: 0x0043B6EA File Offset: 0x004398EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D3D8 RID: 119768 RVA: 0x0043B6F4 File Offset: 0x004398F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurRoleId);
			}
			this.roleInfos_.WriteTo(ref output, WorldTeamPlayerFightInfo._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D3D9 RID: 119769 RVA: 0x0043B744 File Offset: 0x00439944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRoleId);
			}
			num += this.roleInfos_.CalculateSize(WorldTeamPlayerFightInfo._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D3DA RID: 119770 RVA: 0x0043B798 File Offset: 0x00439998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldTeamPlayerFightInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurRoleId != 0)
			{
				this.CurRoleId = other.CurRoleId;
			}
			this.roleInfos_.Add(other.roleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D3DB RID: 119771 RVA: 0x0043B7E5 File Offset: 0x004399E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D3DC RID: 119772 RVA: 0x0043B7F0 File Offset: 0x004399F0
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
				if (num != 16U)
				{
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleInfos_.AddEntriesFrom(ref input, WorldTeamPlayerFightInfo._repeated_roleInfos_codec);
					}
				}
				else
				{
					this.CurRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A7AA RID: 42922
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A7AB RID: 42923
		public const int CurRoleIdFieldNumber = 2;

		// Token: 0x0400A7AC RID: 42924
		private int curRoleId_;

		// Token: 0x0400A7AD RID: 42925
		public const int RoleInfosFieldNumber = 3;

		// Token: 0x0400A7AE RID: 42926
		private static readonly FieldCodec<WorldTeamRoleInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<WorldTeamRoleInfo>(26U, WorldTeamRoleInfo.Parser);

		// Token: 0x0400A7AF RID: 42927
		private readonly RepeatedField<WorldTeamRoleInfo> roleInfos_ = new RepeatedField<WorldTeamRoleInfo>();
	}
}
