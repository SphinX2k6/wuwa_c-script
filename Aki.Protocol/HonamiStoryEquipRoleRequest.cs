using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000763 RID: 1891
	[NetMessage(EMessageId.HonamiStoryEquipRoleRequest)]
	public sealed class HonamiStoryEquipRoleRequest : IMessage<HonamiStoryEquipRoleRequest>, IMessage, IEquatable<HonamiStoryEquipRoleRequest>, IDeepCloneable<HonamiStoryEquipRoleRequest>, IBufferMessage
	{
		// Token: 0x0600AB5A RID: 43866 RVA: 0x0019C713 File Offset: 0x0019A913
		[NullableContext(1)]
		public static HonamiStoryEquipRoleRequest Create()
		{
			return new HonamiStoryEquipRoleRequest();
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x0600AB5B RID: 43867 RVA: 0x0019C71A File Offset: 0x0019A91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x0019C71D File Offset: 0x0019A91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryEquipRoleRequest.Descriptor;
			}
		}

		// Token: 0x0600AB5D RID: 43869 RVA: 0x0019C724 File Offset: 0x0019A924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleRequest()
		{
		}

		// Token: 0x0600AB5E RID: 43870 RVA: 0x0019C737 File Offset: 0x0019A937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleRequest(HonamiStoryEquipRoleRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleId_ = other.roleId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB5F RID: 43871 RVA: 0x0019C76D File Offset: 0x0019A96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEquipRoleRequest Clone()
		{
			return new HonamiStoryEquipRoleRequest(this);
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x0600AB60 RID: 43872 RVA: 0x0019C775 File Offset: 0x0019A975
		// (set) Token: 0x0600AB61 RID: 43873 RVA: 0x0019C77D File Offset: 0x0019A97D
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

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x0600AB62 RID: 43874 RVA: 0x0019C786 File Offset: 0x0019A986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x0600AB63 RID: 43875 RVA: 0x0019C78E File Offset: 0x0019A98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryEquipRoleRequest);
		}

		// Token: 0x0600AB64 RID: 43876 RVA: 0x0019C79C File Offset: 0x0019A99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryEquipRoleRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.roleId_.Equals(other.roleId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB65 RID: 43877 RVA: 0x0019C7EC File Offset: 0x0019A9EC
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

		// Token: 0x0600AB66 RID: 43878 RVA: 0x0019C839 File Offset: 0x0019AA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB67 RID: 43879 RVA: 0x0019C846 File Offset: 0x0019AA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB68 RID: 43880 RVA: 0x0019C850 File Offset: 0x0019AA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleId_.WriteTo(ref output, HonamiStoryEquipRoleRequest._repeated_roleId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB69 RID: 43881 RVA: 0x0019C8A0 File Offset: 0x0019AAA0
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

		// Token: 0x0600AB6A RID: 43882 RVA: 0x0019C8F4 File Offset: 0x0019AAF4
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

		// Token: 0x0600AB6B RID: 43883 RVA: 0x0019C941 File Offset: 0x0019AB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB6C RID: 43884 RVA: 0x0019C94C File Offset: 0x0019AB4C
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
				if (num != 72U && num != 74U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.roleId_.AddEntriesFrom(ref input, HonamiStoryEquipRoleRequest._repeated_roleId_codec);
				}
			}
		}

		// Token: 0x04004E24 RID: 20004
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E25 RID: 20005
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04004E26 RID: 20006
		private int activityId_;

		// Token: 0x04004E27 RID: 20007
		public const int RoleIdFieldNumber = 9;

		// Token: 0x04004E28 RID: 20008
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04004E29 RID: 20009
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();
	}
}
