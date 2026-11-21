using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBD RID: 3261
	[NetMessage(EMessageId.PhantomEquipGroupInfosRequest)]
	public sealed class PhantomEquipGroupInfosRequest : IMessage<PhantomEquipGroupInfosRequest>, IMessage, IEquatable<PhantomEquipGroupInfosRequest>, IDeepCloneable<PhantomEquipGroupInfosRequest>, IBufferMessage
	{
		// Token: 0x06011AD8 RID: 72408 RVA: 0x00296D35 File Offset: 0x00294F35
		[NullableContext(1)]
		public static PhantomEquipGroupInfosRequest Create()
		{
			return new PhantomEquipGroupInfosRequest();
		}

		// Token: 0x17003A90 RID: 14992
		// (get) Token: 0x06011AD9 RID: 72409 RVA: 0x00296D3C File Offset: 0x00294F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A91 RID: 14993
		// (get) Token: 0x06011ADA RID: 72410 RVA: 0x00296D3F File Offset: 0x00294F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomEquipGroupInfosRequest.Descriptor;
			}
		}

		// Token: 0x06011ADB RID: 72411 RVA: 0x00296D46 File Offset: 0x00294F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosRequest()
		{
		}

		// Token: 0x06011ADC RID: 72412 RVA: 0x00296D4E File Offset: 0x00294F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosRequest(PhantomEquipGroupInfosRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011ADD RID: 72413 RVA: 0x00296D73 File Offset: 0x00294F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosRequest Clone()
		{
			return new PhantomEquipGroupInfosRequest(this);
		}

		// Token: 0x17003A92 RID: 14994
		// (get) Token: 0x06011ADE RID: 72414 RVA: 0x00296D7B File Offset: 0x00294F7B
		// (set) Token: 0x06011ADF RID: 72415 RVA: 0x00296D83 File Offset: 0x00294F83
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

		// Token: 0x06011AE0 RID: 72416 RVA: 0x00296D8C File Offset: 0x00294F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomEquipGroupInfosRequest);
		}

		// Token: 0x06011AE1 RID: 72417 RVA: 0x00296D9A File Offset: 0x00294F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomEquipGroupInfosRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011AE2 RID: 72418 RVA: 0x00296DC8 File Offset: 0x00294FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011AE3 RID: 72419 RVA: 0x00296E07 File Offset: 0x00295007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011AE4 RID: 72420 RVA: 0x00296E14 File Offset: 0x00295014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011AE5 RID: 72421 RVA: 0x00296E1D File Offset: 0x0029501D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011AE6 RID: 72422 RVA: 0x00296E50 File Offset: 0x00295050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011AE7 RID: 72423 RVA: 0x00296E8E File Offset: 0x0029508E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomEquipGroupInfosRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011AE8 RID: 72424 RVA: 0x00296EBF File Offset: 0x002950BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011AE9 RID: 72425 RVA: 0x00296EC8 File Offset: 0x002950C8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F95 RID: 28565
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F96 RID: 28566
		public const int RoleIdFieldNumber = 11;

		// Token: 0x04006F97 RID: 28567
		private int roleId_;
	}
}
