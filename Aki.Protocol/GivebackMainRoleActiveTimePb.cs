using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F1 RID: 1777
	public sealed class GivebackMainRoleActiveTimePb : IMessage<GivebackMainRoleActiveTimePb>, IMessage, IEquatable<GivebackMainRoleActiveTimePb>, IDeepCloneable<GivebackMainRoleActiveTimePb>, IBufferMessage
	{
		// Token: 0x0600A1F1 RID: 41457 RVA: 0x00187B10 File Offset: 0x00185D10
		[NullableContext(1)]
		public static GivebackMainRoleActiveTimePb Create()
		{
			return new GivebackMainRoleActiveTimePb();
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x0600A1F2 RID: 41458 RVA: 0x00187B17 File Offset: 0x00185D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GivebackMainRoleActiveTimePb> Parser
		{
			get
			{
				return GivebackMainRoleActiveTimePb._parser;
			}
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x0600A1F3 RID: 41459 RVA: 0x00187B1E File Offset: 0x00185D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x0600A1F4 RID: 41460 RVA: 0x00187B21 File Offset: 0x00185D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackMainRoleActiveTimePb.Descriptor;
			}
		}

		// Token: 0x0600A1F5 RID: 41461 RVA: 0x00187B28 File Offset: 0x00185D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackMainRoleActiveTimePb()
		{
		}

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x00187B30 File Offset: 0x00185D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackMainRoleActiveTimePb(GivebackMainRoleActiveTimePb other) : this()
		{
			this.roleId_ = other.roleId_;
			this.activeTime_ = other.activeTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x00187B61 File Offset: 0x00185D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackMainRoleActiveTimePb Clone()
		{
			return new GivebackMainRoleActiveTimePb(this);
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x0600A1F8 RID: 41464 RVA: 0x00187B69 File Offset: 0x00185D69
		// (set) Token: 0x0600A1F9 RID: 41465 RVA: 0x00187B71 File Offset: 0x00185D71
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

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x0600A1FA RID: 41466 RVA: 0x00187B7A File Offset: 0x00185D7A
		// (set) Token: 0x0600A1FB RID: 41467 RVA: 0x00187B82 File Offset: 0x00185D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ActiveTime
		{
			get
			{
				return this.activeTime_;
			}
			set
			{
				this.activeTime_ = value;
			}
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x00187B8B File Offset: 0x00185D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackMainRoleActiveTimePb);
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x00187B99 File Offset: 0x00185D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackMainRoleActiveTimePb other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.ActiveTime == other.ActiveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1FE RID: 41470 RVA: 0x00187BD8 File Offset: 0x00185DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.ActiveTime != 0L)
			{
				num ^= this.ActiveTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x00187C30 File Offset: 0x00185E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A200 RID: 41472 RVA: 0x00187C3D File Offset: 0x00185E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A201 RID: 41473 RVA: 0x00187C48 File Offset: 0x00185E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.ActiveTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ActiveTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A202 RID: 41474 RVA: 0x00187CA0 File Offset: 0x00185EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.ActiveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ActiveTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A203 RID: 41475 RVA: 0x00187CF8 File Offset: 0x00185EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackMainRoleActiveTimePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.ActiveTime != 0L)
			{
				this.ActiveTime = other.ActiveTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A204 RID: 41476 RVA: 0x00187D48 File Offset: 0x00185F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A205 RID: 41477 RVA: 0x00187D54 File Offset: 0x00185F54
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActiveTime = input.ReadInt64();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B1B RID: 19227
		private static readonly MessageParser<GivebackMainRoleActiveTimePb> _parser = new MessageParser<GivebackMainRoleActiveTimePb>(() => new GivebackMainRoleActiveTimePb());

		// Token: 0x04004B1C RID: 19228
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B1D RID: 19229
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04004B1E RID: 19230
		private int roleId_;

		// Token: 0x04004B1F RID: 19231
		public const int ActiveTimeFieldNumber = 2;

		// Token: 0x04004B20 RID: 19232
		private long activeTime_;
	}
}
