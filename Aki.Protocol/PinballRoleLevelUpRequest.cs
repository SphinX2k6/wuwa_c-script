using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D59 RID: 3417
	[NetMessage(EMessageId.PinballRoleLevelUpRequest)]
	public sealed class PinballRoleLevelUpRequest : IMessage<PinballRoleLevelUpRequest>, IMessage, IEquatable<PinballRoleLevelUpRequest>, IDeepCloneable<PinballRoleLevelUpRequest>, IBufferMessage
	{
		// Token: 0x060126F4 RID: 75508 RVA: 0x002B0D07 File Offset: 0x002AEF07
		[NullableContext(1)]
		public static PinballRoleLevelUpRequest Create()
		{
			return new PinballRoleLevelUpRequest();
		}

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x060126F5 RID: 75509 RVA: 0x002B0D0E File Offset: 0x002AEF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x060126F6 RID: 75510 RVA: 0x002B0D11 File Offset: 0x002AEF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballRoleLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x060126F7 RID: 75511 RVA: 0x002B0D18 File Offset: 0x002AEF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpRequest()
		{
		}

		// Token: 0x060126F8 RID: 75512 RVA: 0x002B0D20 File Offset: 0x002AEF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpRequest(PinballRoleLevelUpRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.addLv_ = other.addLv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060126F9 RID: 75513 RVA: 0x002B0D51 File Offset: 0x002AEF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoleLevelUpRequest Clone()
		{
			return new PinballRoleLevelUpRequest(this);
		}

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x060126FA RID: 75514 RVA: 0x002B0D59 File Offset: 0x002AEF59
		// (set) Token: 0x060126FB RID: 75515 RVA: 0x002B0D61 File Offset: 0x002AEF61
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

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x060126FC RID: 75516 RVA: 0x002B0D6A File Offset: 0x002AEF6A
		// (set) Token: 0x060126FD RID: 75517 RVA: 0x002B0D72 File Offset: 0x002AEF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AddLv
		{
			get
			{
				return this.addLv_;
			}
			set
			{
				this.addLv_ = value;
			}
		}

		// Token: 0x060126FE RID: 75518 RVA: 0x002B0D7B File Offset: 0x002AEF7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballRoleLevelUpRequest);
		}

		// Token: 0x060126FF RID: 75519 RVA: 0x002B0D89 File Offset: 0x002AEF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballRoleLevelUpRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.AddLv == other.AddLv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012700 RID: 75520 RVA: 0x002B0DC8 File Offset: 0x002AEFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.AddLv != 0)
			{
				num ^= this.AddLv.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012701 RID: 75521 RVA: 0x002B0E20 File Offset: 0x002AF020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012702 RID: 75522 RVA: 0x002B0E2D File Offset: 0x002AF02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012703 RID: 75523 RVA: 0x002B0E38 File Offset: 0x002AF038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AddLv != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.AddLv);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012704 RID: 75524 RVA: 0x002B0E94 File Offset: 0x002AF094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.AddLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AddLv);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012705 RID: 75525 RVA: 0x002B0EEC File Offset: 0x002AF0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballRoleLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.AddLv != 0)
			{
				this.AddLv = other.AddLv;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012706 RID: 75526 RVA: 0x002B0F3C File Offset: 0x002AF13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012707 RID: 75527 RVA: 0x002B0F48 File Offset: 0x002AF148
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
				if (num != 40U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.AddLv = input.ReadInt32();
				}
			}
		}

		// Token: 0x040072C5 RID: 29381
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072C6 RID: 29382
		public const int RoleIdFieldNumber = 7;

		// Token: 0x040072C7 RID: 29383
		private int roleId_;

		// Token: 0x040072C8 RID: 29384
		public const int AddLvFieldNumber = 5;

		// Token: 0x040072C9 RID: 29385
		private int addLv_;
	}
}
