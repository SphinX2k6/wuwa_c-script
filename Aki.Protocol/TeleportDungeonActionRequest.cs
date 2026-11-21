using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A9 RID: 5033
	[NetMessage(EMessageId.TeleportDungeonActionRequest)]
	public sealed class TeleportDungeonActionRequest : IMessage<TeleportDungeonActionRequest>, IMessage, IEquatable<TeleportDungeonActionRequest>, IDeepCloneable<TeleportDungeonActionRequest>, IBufferMessage
	{
		// Token: 0x0601AC96 RID: 109718 RVA: 0x003E69E1 File Offset: 0x003E4BE1
		[NullableContext(1)]
		public static TeleportDungeonActionRequest Create()
		{
			return new TeleportDungeonActionRequest();
		}

		// Token: 0x17005AB2 RID: 23218
		// (get) Token: 0x0601AC97 RID: 109719 RVA: 0x003E69E8 File Offset: 0x003E4BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AB3 RID: 23219
		// (get) Token: 0x0601AC98 RID: 109720 RVA: 0x003E69EB File Offset: 0x003E4BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDungeonActionRequest.Descriptor;
			}
		}

		// Token: 0x0601AC99 RID: 109721 RVA: 0x003E69F2 File Offset: 0x003E4BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionRequest()
		{
		}

		// Token: 0x0601AC9A RID: 109722 RVA: 0x003E6A08 File Offset: 0x003E4C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionRequest(TeleportDungeonActionRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.incId_ = other.incId_;
			this.roleIds_ = other.roleIds_.Clone();
			this.isConfirm_ = other.isConfirm_;
			this.continueLastInst_ = other.continueLastInst_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC9B RID: 109723 RVA: 0x003E6A6D File Offset: 0x003E4C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonActionRequest Clone()
		{
			return new TeleportDungeonActionRequest(this);
		}

		// Token: 0x17005AB4 RID: 23220
		// (get) Token: 0x0601AC9C RID: 109724 RVA: 0x003E6A75 File Offset: 0x003E4C75
		// (set) Token: 0x0601AC9D RID: 109725 RVA: 0x003E6A7D File Offset: 0x003E4C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x17005AB5 RID: 23221
		// (get) Token: 0x0601AC9E RID: 109726 RVA: 0x003E6A86 File Offset: 0x003E4C86
		// (set) Token: 0x0601AC9F RID: 109727 RVA: 0x003E6A8E File Offset: 0x003E4C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17005AB6 RID: 23222
		// (get) Token: 0x0601ACA0 RID: 109728 RVA: 0x003E6A97 File Offset: 0x003E4C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17005AB7 RID: 23223
		// (get) Token: 0x0601ACA1 RID: 109729 RVA: 0x003E6A9F File Offset: 0x003E4C9F
		// (set) Token: 0x0601ACA2 RID: 109730 RVA: 0x003E6AA7 File Offset: 0x003E4CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConfirm
		{
			get
			{
				return this.isConfirm_;
			}
			set
			{
				this.isConfirm_ = value;
			}
		}

		// Token: 0x17005AB8 RID: 23224
		// (get) Token: 0x0601ACA3 RID: 109731 RVA: 0x003E6AB0 File Offset: 0x003E4CB0
		// (set) Token: 0x0601ACA4 RID: 109732 RVA: 0x003E6AB8 File Offset: 0x003E4CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueLastInst
		{
			get
			{
				return this.continueLastInst_;
			}
			set
			{
				this.continueLastInst_ = value;
			}
		}

		// Token: 0x0601ACA5 RID: 109733 RVA: 0x003E6AC1 File Offset: 0x003E4CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDungeonActionRequest);
		}

		// Token: 0x0601ACA6 RID: 109734 RVA: 0x003E6AD0 File Offset: 0x003E4CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDungeonActionRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.IncId == other.IncId && this.roleIds_.Equals(other.roleIds_) && this.IsConfirm == other.IsConfirm && this.ContinueLastInst == other.ContinueLastInst && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ACA7 RID: 109735 RVA: 0x003E6B50 File Offset: 0x003E4D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this.IsConfirm)
			{
				num ^= this.IsConfirm.GetHashCode();
			}
			if (this.ContinueLastInst)
			{
				num ^= this.ContinueLastInst.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ACA8 RID: 109736 RVA: 0x003E6BE8 File Offset: 0x003E4DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ACA9 RID: 109737 RVA: 0x003E6BF5 File Offset: 0x003E4DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACAA RID: 109738 RVA: 0x003E6C00 File Offset: 0x003E4E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContinueLastInst)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ContinueLastInst);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IncId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.IsConfirm)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsConfirm);
			}
			this.roleIds_.WriteTo(ref output, TeleportDungeonActionRequest._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ACAB RID: 109739 RVA: 0x003E6CA4 File Offset: 0x003E4EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.roleIds_.CalculateSize(TeleportDungeonActionRequest._repeated_roleIds_codec);
			if (this.IsConfirm)
			{
				num += 2;
			}
			if (this.ContinueLastInst)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ACAC RID: 109740 RVA: 0x003E6D28 File Offset: 0x003E4F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDungeonActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this.roleIds_.Add(other.roleIds_);
			if (other.IsConfirm)
			{
				this.IsConfirm = other.IsConfirm;
			}
			if (other.ContinueLastInst)
			{
				this.ContinueLastInst = other.ContinueLastInst;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ACAD RID: 109741 RVA: 0x003E6DB1 File Offset: 0x003E4FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACAE RID: 109742 RVA: 0x003E6DBC File Offset: 0x003E4FBC
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.ContinueLastInst = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.IsConfirm = input.ReadBool();
						continue;
					}
					if (num == 96U || num == 98U)
					{
						this.roleIds_.AddEntriesFrom(ref input, TeleportDungeonActionRequest._repeated_roleIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009CC0 RID: 40128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CC1 RID: 40129
		public const int HostPlayerIdFieldNumber = 8;

		// Token: 0x04009CC2 RID: 40130
		private int hostPlayerId_;

		// Token: 0x04009CC3 RID: 40131
		public const int IncIdFieldNumber = 6;

		// Token: 0x04009CC4 RID: 40132
		private int incId_;

		// Token: 0x04009CC5 RID: 40133
		public const int RoleIdsFieldNumber = 12;

		// Token: 0x04009CC6 RID: 40134
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04009CC7 RID: 40135
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04009CC8 RID: 40136
		public const int IsConfirmFieldNumber = 9;

		// Token: 0x04009CC9 RID: 40137
		private bool isConfirm_;

		// Token: 0x04009CCA RID: 40138
		public const int ContinueLastInstFieldNumber = 2;

		// Token: 0x04009CCB RID: 40139
		private bool continueLastInst_;
	}
}
