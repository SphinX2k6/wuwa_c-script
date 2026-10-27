using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AD RID: 5037
	public sealed class TowerDefenceRoleInfo : IMessage<TowerDefenceRoleInfo>, IMessage, IEquatable<TowerDefenceRoleInfo>, IDeepCloneable<TowerDefenceRoleInfo>, IBufferMessage
	{
		// Token: 0x0601AB94 RID: 109460 RVA: 0x003E0221 File Offset: 0x003DE421
		[NullableContext(1)]
		public static TowerDefenceRoleInfo Create()
		{
			return new TowerDefenceRoleInfo();
		}

		// Token: 0x17005A1D RID: 23069
		// (get) Token: 0x0601AB95 RID: 109461 RVA: 0x003E0228 File Offset: 0x003DE428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefenceRoleInfo> Parser
		{
			get
			{
				return TowerDefenceRoleInfo._parser;
			}
		}

		// Token: 0x17005A1E RID: 23070
		// (get) Token: 0x0601AB96 RID: 109462 RVA: 0x003E022F File Offset: 0x003DE42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A1F RID: 23071
		// (get) Token: 0x0601AB97 RID: 109463 RVA: 0x003E0232 File Offset: 0x003DE432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRoleInfo.Descriptor;
			}
		}

		// Token: 0x0601AB98 RID: 109464 RVA: 0x003E0239 File Offset: 0x003DE439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleInfo()
		{
		}

		// Token: 0x0601AB99 RID: 109465 RVA: 0x003E0244 File Offset: 0x003DE444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleInfo(TowerDefenceRoleInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.phantom_ = ((other.phantom_ != null) ? other.phantom_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB9A RID: 109466 RVA: 0x003E0290 File Offset: 0x003DE490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleInfo Clone()
		{
			return new TowerDefenceRoleInfo(this);
		}

		// Token: 0x17005A20 RID: 23072
		// (get) Token: 0x0601AB9B RID: 109467 RVA: 0x003E0298 File Offset: 0x003DE498
		// (set) Token: 0x0601AB9C RID: 109468 RVA: 0x003E02A0 File Offset: 0x003DE4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17005A21 RID: 23073
		// (get) Token: 0x0601AB9D RID: 109469 RVA: 0x003E02A9 File Offset: 0x003DE4A9
		// (set) Token: 0x0601AB9E RID: 109470 RVA: 0x003E02B1 File Offset: 0x003DE4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfo Phantom
		{
			get
			{
				return this.phantom_;
			}
			set
			{
				this.phantom_ = value;
			}
		}

		// Token: 0x0601AB9F RID: 109471 RVA: 0x003E02BA File Offset: 0x003DE4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRoleInfo);
		}

		// Token: 0x0601ABA0 RID: 109472 RVA: 0x003E02C8 File Offset: 0x003DE4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRoleInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this.Phantom, other.Phantom) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ABA1 RID: 109473 RVA: 0x003E0318 File Offset: 0x003DE518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.phantom_ != null)
			{
				num ^= this.Phantom.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ABA2 RID: 109474 RVA: 0x003E036D File Offset: 0x003DE56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ABA3 RID: 109475 RVA: 0x003E037A File Offset: 0x003DE57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ABA4 RID: 109476 RVA: 0x003E0384 File Offset: 0x003DE584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.phantom_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Phantom);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ABA5 RID: 109477 RVA: 0x003E03DC File Offset: 0x003DE5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.phantom_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Phantom);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ABA6 RID: 109478 RVA: 0x003E0434 File Offset: 0x003DE634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.phantom_ != null)
			{
				if (this.phantom_ == null)
				{
					this.Phantom = new TowerDefencePhantomInfo();
				}
				this.Phantom.MergeFrom(other.Phantom);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ABA7 RID: 109479 RVA: 0x003E049C File Offset: 0x003DE69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ABA8 RID: 109480 RVA: 0x003E04A8 File Offset: 0x003DE6A8
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
						if (this.phantom_ == null)
						{
							this.Phantom = new TowerDefencePhantomInfo();
						}
						input.ReadMessage(this.Phantom);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009B2F RID: 39727
		private static readonly MessageParser<TowerDefenceRoleInfo> _parser = new MessageParser<TowerDefenceRoleInfo>(() => new TowerDefenceRoleInfo());

		// Token: 0x04009B30 RID: 39728
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B31 RID: 39729
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009B32 RID: 39730
		private int roleId_;

		// Token: 0x04009B33 RID: 39731
		public const int PhantomFieldNumber = 2;

		// Token: 0x04009B34 RID: 39732
		private TowerDefencePhantomInfo phantom_;
	}
}
