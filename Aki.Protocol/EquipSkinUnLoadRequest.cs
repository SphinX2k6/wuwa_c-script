using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D7 RID: 1239
	[NetMessage(EMessageId.EquipSkinUnLoadRequest)]
	public sealed class EquipSkinUnLoadRequest : IMessage<EquipSkinUnLoadRequest>, IMessage, IEquatable<EquipSkinUnLoadRequest>, IDeepCloneable<EquipSkinUnLoadRequest>, IBufferMessage
	{
		// Token: 0x0600759A RID: 30106 RVA: 0x0011FDB0 File Offset: 0x0011DFB0
		[NullableContext(1)]
		public static EquipSkinUnLoadRequest Create()
		{
			return new EquipSkinUnLoadRequest();
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x0600759B RID: 30107 RVA: 0x0011FDB7 File Offset: 0x0011DFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x0600759C RID: 30108 RVA: 0x0011FDBA File Offset: 0x0011DFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipSkinUnLoadRequest.Descriptor;
			}
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x0011FDC1 File Offset: 0x0011DFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadRequest()
		{
		}

		// Token: 0x0600759E RID: 30110 RVA: 0x0011FDC9 File Offset: 0x0011DFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadRequest(EquipSkinUnLoadRequest other) : this()
		{
			this.roleID_ = other.roleID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x0011FDEE File Offset: 0x0011DFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinUnLoadRequest Clone()
		{
			return new EquipSkinUnLoadRequest(this);
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x060075A0 RID: 30112 RVA: 0x0011FDF6 File Offset: 0x0011DFF6
		// (set) Token: 0x060075A1 RID: 30113 RVA: 0x0011FDFE File Offset: 0x0011DFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleID
		{
			get
			{
				return this.roleID_;
			}
			set
			{
				this.roleID_ = value;
			}
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x0011FE07 File Offset: 0x0011E007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipSkinUnLoadRequest);
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x0011FE15 File Offset: 0x0011E015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipSkinUnLoadRequest other)
		{
			return other != null && (other == this || (this.RoleID == other.RoleID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x0011FE44 File Offset: 0x0011E044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleID != 0)
			{
				num ^= this.RoleID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x0011FE83 File Offset: 0x0011E083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x0011FE90 File Offset: 0x0011E090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x0011FE99 File Offset: 0x0011E099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleID != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoleID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x0011FECC File Offset: 0x0011E0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleID != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x0011FF0A File Offset: 0x0011E10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipSkinUnLoadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleID != 0)
			{
				this.RoleID = other.RoleID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x0011FF3B File Offset: 0x0011E13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x0011FF44 File Offset: 0x0011E144
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleID = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003DBC RID: 15804
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DBD RID: 15805
		public const int RoleIDFieldNumber = 9;

		// Token: 0x04003DBE RID: 15806
		private int roleID_;
	}
}
