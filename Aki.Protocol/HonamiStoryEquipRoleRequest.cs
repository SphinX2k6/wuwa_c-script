using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000777 RID: 1911
	[NetMessage(EMessageId.HonamiStoryEquipRoleRequest)]
	public sealed class HonamiStoryEquipRoleRequest : IMessage<HonamiStoryEquipRoleRequest>, IMessage, IEquatable<HonamiStoryEquipRoleRequest>, IDeepCloneable<HonamiStoryEquipRoleRequest>, IBufferMessage
	{
		// Token: 0x0600ACB0 RID: 44208 RVA: 0x0019F13B File Offset: 0x0019D33B
		[NullableContext(1)]
		public static HonamiStoryEquipRoleRequest Create()
		{
			return new HonamiStoryEquipRoleRequest();
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x0600ACB1 RID: 44209 RVA: 0x0019F142 File Offset: 0x0019D342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x0600ACB2 RID: 44210 RVA: 0x0019F145 File Offset: 0x0019D345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryEquipRoleRequest.Descriptor;
			}
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x0019F14C File Offset: 0x0019D34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleRequest()
		{
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x0019F15F File Offset: 0x0019D35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleRequest(HonamiStoryEquipRoleRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleId_ = other.roleId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x0019F195 File Offset: 0x0019D395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleRequest Clone()
		{
			return new HonamiStoryEquipRoleRequest(this);
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x0600ACB6 RID: 44214 RVA: 0x0019F19D File Offset: 0x0019D39D
		// (set) Token: 0x0600ACB7 RID: 44215 RVA: 0x0019F1A5 File Offset: 0x0019D3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x0600ACB8 RID: 44216 RVA: 0x0019F1AE File Offset: 0x0019D3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x0019F1B6 File Offset: 0x0019D3B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryEquipRoleRequest);
		}

		// Token: 0x0600ACBA RID: 44218 RVA: 0x0019F1C4 File Offset: 0x0019D3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryEquipRoleRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.roleId_.Equals(other.roleId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACBB RID: 44219 RVA: 0x0019F214 File Offset: 0x0019D414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.roleId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x0019F261 File Offset: 0x0019D461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ACBD RID: 44221 RVA: 0x0019F26E File Offset: 0x0019D46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACBE RID: 44222 RVA: 0x0019F278 File Offset: 0x0019D478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			this.roleId_.WriteTo(ref output, HonamiStoryEquipRoleRequest._repeated_roleId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACBF RID: 44223 RVA: 0x0019F2C8 File Offset: 0x0019D4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.roleId_.CalculateSize(HonamiStoryEquipRoleRequest._repeated_roleId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x0019F31C File Offset: 0x0019D51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryEquipRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.roleId_.Add(other.roleId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ACC1 RID: 44225 RVA: 0x0019F369 File Offset: 0x0019D569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACC2 RID: 44226 RVA: 0x0019F374 File Offset: 0x0019D574
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
				if (num != 56U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleId_.AddEntriesFrom(ref input, HonamiStoryEquipRoleRequest._repeated_roleId_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E2B RID: 20011
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E2C RID: 20012
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04004E2D RID: 20013
		private int activityId_;

		// Token: 0x04004E2E RID: 20014
		public const int RoleIdFieldNumber = 12;

		// Token: 0x04004E2F RID: 20015
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04004E30 RID: 20016
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();
	}
}
