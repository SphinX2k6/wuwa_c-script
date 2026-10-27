using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151E RID: 5406
	public sealed class WorldTeamPlayerFightInfo : IMessage<WorldTeamPlayerFightInfo>, IMessage, IEquatable<WorldTeamPlayerFightInfo>, IDeepCloneable<WorldTeamPlayerFightInfo>, IBufferMessage
	{
		// Token: 0x0601C903 RID: 116995 RVA: 0x0041FAF8 File Offset: 0x0041DCF8
		[NullableContext(1)]
		public static WorldTeamPlayerFightInfo Create()
		{
			return new WorldTeamPlayerFightInfo();
		}

		// Token: 0x17006044 RID: 24644
		// (get) Token: 0x0601C904 RID: 116996 RVA: 0x0041FAFF File Offset: 0x0041DCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006045 RID: 24645
		// (get) Token: 0x0601C905 RID: 116997 RVA: 0x0041FB02 File Offset: 0x0041DD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldTeamPlayerFightInfo.Descriptor;
			}
		}

		// Token: 0x0601C906 RID: 116998 RVA: 0x0041FB09 File Offset: 0x0041DD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerFightInfo()
		{
		}

		// Token: 0x0601C907 RID: 116999 RVA: 0x0041FB1C File Offset: 0x0041DD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerFightInfo(WorldTeamPlayerFightInfo other) : this()
		{
			this.curRoleId_ = other.curRoleId_;
			this.roleInfos_ = other.roleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C908 RID: 117000 RVA: 0x0041FB52 File Offset: 0x0041DD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldTeamPlayerFightInfo Clone()
		{
			return new WorldTeamPlayerFightInfo(this);
		}

		// Token: 0x17006046 RID: 24646
		// (get) Token: 0x0601C909 RID: 117001 RVA: 0x0041FB5A File Offset: 0x0041DD5A
		// (set) Token: 0x0601C90A RID: 117002 RVA: 0x0041FB62 File Offset: 0x0041DD62
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

		// Token: 0x17006047 RID: 24647
		// (get) Token: 0x0601C90B RID: 117003 RVA: 0x0041FB6B File Offset: 0x0041DD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WorldTeamRoleInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x0601C90C RID: 117004 RVA: 0x0041FB73 File Offset: 0x0041DD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldTeamPlayerFightInfo);
		}

		// Token: 0x0601C90D RID: 117005 RVA: 0x0041FB84 File Offset: 0x0041DD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldTeamPlayerFightInfo other)
		{
			return other != null && (other == this || (this.CurRoleId == other.CurRoleId && this.roleInfos_.Equals(other.roleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C90E RID: 117006 RVA: 0x0041FBD4 File Offset: 0x0041DDD4
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

		// Token: 0x0601C90F RID: 117007 RVA: 0x0041FC21 File Offset: 0x0041DE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C910 RID: 117008 RVA: 0x0041FC2E File Offset: 0x0041DE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C911 RID: 117009 RVA: 0x0041FC38 File Offset: 0x0041DE38
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

		// Token: 0x0601C912 RID: 117010 RVA: 0x0041FC88 File Offset: 0x0041DE88
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

		// Token: 0x0601C913 RID: 117011 RVA: 0x0041FCDC File Offset: 0x0041DEDC
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

		// Token: 0x0601C914 RID: 117012 RVA: 0x0041FD29 File Offset: 0x0041DF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C915 RID: 117013 RVA: 0x0041FD34 File Offset: 0x0041DF34
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

		// Token: 0x0400A351 RID: 41809
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A352 RID: 41810
		public const int CurRoleIdFieldNumber = 2;

		// Token: 0x0400A353 RID: 41811
		private int curRoleId_;

		// Token: 0x0400A354 RID: 41812
		public const int RoleInfosFieldNumber = 3;

		// Token: 0x0400A355 RID: 41813
		private static readonly FieldCodec<WorldTeamRoleInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<WorldTeamRoleInfo>(26U, WorldTeamRoleInfo.Parser);

		// Token: 0x0400A356 RID: 41814
		private readonly RepeatedField<WorldTeamRoleInfo> roleInfos_ = new RepeatedField<WorldTeamRoleInfo>();
	}
}
