using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105B RID: 4187
	public sealed class RoleBuffUnlockView : IMessage<RoleBuffUnlockView>, IMessage, IEquatable<RoleBuffUnlockView>, IDeepCloneable<RoleBuffUnlockView>, IBufferMessage
	{
		// Token: 0x060165F8 RID: 91640 RVA: 0x00340507 File Offset: 0x0033E707
		[NullableContext(1)]
		public static RoleBuffUnlockView Create()
		{
			return new RoleBuffUnlockView();
		}

		// Token: 0x17004ADA RID: 19162
		// (get) Token: 0x060165F9 RID: 91641 RVA: 0x0034050E File Offset: 0x0033E70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ADB RID: 19163
		// (get) Token: 0x060165FA RID: 91642 RVA: 0x00340511 File Offset: 0x0033E711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleBuffUnlockView.Descriptor;
			}
		}

		// Token: 0x060165FB RID: 91643 RVA: 0x00340518 File Offset: 0x0033E718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBuffUnlockView()
		{
		}

		// Token: 0x060165FC RID: 91644 RVA: 0x0034052C File Offset: 0x0033E72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBuffUnlockView(RoleBuffUnlockView other) : this()
		{
			this.rogueResRole_ = ((other.rogueResRole_ != null) ? other.rogueResRole_.Clone() : null);
			this.buffs_ = other.buffs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060165FD RID: 91645 RVA: 0x0034057D File Offset: 0x0033E77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleBuffUnlockView Clone()
		{
			return new RoleBuffUnlockView(this);
		}

		// Token: 0x17004ADC RID: 19164
		// (get) Token: 0x060165FE RID: 91646 RVA: 0x00340585 File Offset: 0x0033E785
		// (set) Token: 0x060165FF RID: 91647 RVA: 0x0034058D File Offset: 0x0033E78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRole RogueResRole
		{
			get
			{
				return this.rogueResRole_;
			}
			set
			{
				this.rogueResRole_ = value;
			}
		}

		// Token: 0x17004ADD RID: 19165
		// (get) Token: 0x06016600 RID: 91648 RVA: 0x00340596 File Offset: 0x0033E796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Buffs
		{
			get
			{
				return this.buffs_;
			}
		}

		// Token: 0x06016601 RID: 91649 RVA: 0x0034059E File Offset: 0x0033E79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleBuffUnlockView);
		}

		// Token: 0x06016602 RID: 91650 RVA: 0x003405AC File Offset: 0x0033E7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleBuffUnlockView other)
		{
			return other != null && (other == this || (object.Equals(this.RogueResRole, other.RogueResRole) && this.buffs_.Equals(other.buffs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016603 RID: 91651 RVA: 0x00340600 File Offset: 0x0033E800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueResRole_ != null)
			{
				num ^= this.RogueResRole.GetHashCode();
			}
			num ^= this.buffs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016604 RID: 91652 RVA: 0x0034064A File Offset: 0x0033E84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016605 RID: 91653 RVA: 0x00340657 File Offset: 0x0033E857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016606 RID: 91654 RVA: 0x00340660 File Offset: 0x0033E860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResRole_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RogueResRole);
			}
			this.buffs_.WriteTo(ref output, RoleBuffUnlockView._repeated_buffs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016607 RID: 91655 RVA: 0x003406B0 File Offset: 0x0033E8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueResRole_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResRole);
			}
			num += this.buffs_.CalculateSize(RoleBuffUnlockView._repeated_buffs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016608 RID: 91656 RVA: 0x00340704 File Offset: 0x0033E904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleBuffUnlockView other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueResRole_ != null)
			{
				if (this.rogueResRole_ == null)
				{
					this.RogueResRole = new RogueResRole();
				}
				this.RogueResRole.MergeFrom(other.RogueResRole);
			}
			this.buffs_.Add(other.buffs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016609 RID: 91657 RVA: 0x00340769 File Offset: 0x0033E969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601660A RID: 91658 RVA: 0x00340774 File Offset: 0x0033E974
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
				if (num != 10U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.buffs_.AddEntriesFrom(ref input, RoleBuffUnlockView._repeated_buffs_codec);
					}
				}
				else
				{
					if (this.rogueResRole_ == null)
					{
						this.RogueResRole = new RogueResRole();
					}
					input.ReadMessage(this.RogueResRole);
				}
			}
		}

		// Token: 0x040085D1 RID: 34257
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085D2 RID: 34258
		public const int RogueResRoleFieldNumber = 1;

		// Token: 0x040085D3 RID: 34259
		private RogueResRole rogueResRole_;

		// Token: 0x040085D4 RID: 34260
		public const int BuffsFieldNumber = 2;

		// Token: 0x040085D5 RID: 34261
		private static readonly FieldCodec<int> _repeated_buffs_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040085D6 RID: 34262
		private readonly RepeatedField<int> buffs_ = new RepeatedField<int>();
	}
}
