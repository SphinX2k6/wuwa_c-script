using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000518 RID: 1304
	[NetMessage(EMessageId.FastReturnDungeonRequest)]
	public sealed class FastReturnDungeonRequest : IMessage<FastReturnDungeonRequest>, IMessage, IEquatable<FastReturnDungeonRequest>, IDeepCloneable<FastReturnDungeonRequest>, IBufferMessage
	{
		// Token: 0x06007AC4 RID: 31428 RVA: 0x0012A219 File Offset: 0x00128419
		[NullableContext(1)]
		public static FastReturnDungeonRequest Create()
		{
			return new FastReturnDungeonRequest();
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06007AC5 RID: 31429 RVA: 0x0012A220 File Offset: 0x00128420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06007AC6 RID: 31430 RVA: 0x0012A223 File Offset: 0x00128423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FastReturnDungeonRequest.Descriptor;
			}
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x0012A22A File Offset: 0x0012842A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonRequest()
		{
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x0012A240 File Offset: 0x00128440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonRequest(FastReturnDungeonRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.roleIds_ = other.roleIds_.Clone();
			this.continueInst_ = other.continueInst_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x0012A2A5 File Offset: 0x001284A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonRequest Clone()
		{
			return new FastReturnDungeonRequest(this);
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06007ACA RID: 31434 RVA: 0x0012A2AD File Offset: 0x001284AD
		// (set) Token: 0x06007ACB RID: 31435 RVA: 0x0012A2B5 File Offset: 0x001284B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06007ACC RID: 31436 RVA: 0x0012A2BE File Offset: 0x001284BE
		// (set) Token: 0x06007ACD RID: 31437 RVA: 0x0012A2C6 File Offset: 0x001284C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06007ACE RID: 31438 RVA: 0x0012A2CF File Offset: 0x001284CF
		// (set) Token: 0x06007ACF RID: 31439 RVA: 0x0012A2D7 File Offset: 0x001284D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06007AD0 RID: 31440 RVA: 0x0012A2E0 File Offset: 0x001284E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06007AD1 RID: 31441 RVA: 0x0012A2E8 File Offset: 0x001284E8
		// (set) Token: 0x06007AD2 RID: 31442 RVA: 0x0012A2F0 File Offset: 0x001284F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueInst
		{
			get
			{
				return this.continueInst_;
			}
			set
			{
				this.continueInst_ = value;
			}
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x0012A2F9 File Offset: 0x001284F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FastReturnDungeonRequest);
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x0012A308 File Offset: 0x00128508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FastReturnDungeonRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.roleIds_.Equals(other.roleIds_) && this.ContinueInst == other.ContinueInst && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x0012A388 File Offset: 0x00128588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this.ContinueInst)
			{
				num ^= this.ContinueInst.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x0012A420 File Offset: 0x00128620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x0012A42D File Offset: 0x0012862D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x0012A438 File Offset: 0x00128638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContinueInst)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ContinueInst);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.NodeId);
			}
			this.roleIds_.WriteTo(ref output, FastReturnDungeonRequest._repeated_roleIds_codec);
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x0012A4DC File Offset: 0x001286DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			num += this.roleIds_.CalculateSize(FastReturnDungeonRequest._repeated_roleIds_codec);
			if (this.ContinueInst)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x0012A56C File Offset: 0x0012876C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FastReturnDungeonRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			this.roleIds_.Add(other.roleIds_);
			if (other.ContinueInst)
			{
				this.ContinueInst = other.ContinueInst;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007ADB RID: 31451 RVA: 0x0012A5F5 File Offset: 0x001287F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x0012A600 File Offset: 0x00128800
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
				if (num <= 96U)
				{
					if (num == 48U)
					{
						this.ContinueInst = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						goto IL_61;
					}
				}
				else
				{
					if (num == 98U)
					{
						goto IL_61;
					}
					if (num == 112U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_61:
				this.roleIds_.AddEntriesFrom(ref input, FastReturnDungeonRequest._repeated_roleIds_codec);
			}
		}

		// Token: 0x04003F4F RID: 16207
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F50 RID: 16208
		public const int TreeOwnerIdFieldNumber = 15;

		// Token: 0x04003F51 RID: 16209
		private int treeOwnerId_;

		// Token: 0x04003F52 RID: 16210
		public const int TreeIncIdFieldNumber = 14;

		// Token: 0x04003F53 RID: 16211
		private long treeIncId_;

		// Token: 0x04003F54 RID: 16212
		public const int NodeIdFieldNumber = 10;

		// Token: 0x04003F55 RID: 16213
		private int nodeId_;

		// Token: 0x04003F56 RID: 16214
		public const int RoleIdsFieldNumber = 12;

		// Token: 0x04003F57 RID: 16215
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04003F58 RID: 16216
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04003F59 RID: 16217
		public const int ContinueInstFieldNumber = 6;

		// Token: 0x04003F5A RID: 16218
		private bool continueInst_;
	}
}
