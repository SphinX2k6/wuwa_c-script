using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FA RID: 1530
	[NetMessage(EMessageId.FlySkinUnLoadRequest)]
	public sealed class FlySkinUnLoadRequest : IMessage<FlySkinUnLoadRequest>, IMessage, IEquatable<FlySkinUnLoadRequest>, IDeepCloneable<FlySkinUnLoadRequest>, IBufferMessage
	{
		// Token: 0x06008DEE RID: 36334 RVA: 0x0015884F File Offset: 0x00156A4F
		[NullableContext(1)]
		public static FlySkinUnLoadRequest Create()
		{
			return new FlySkinUnLoadRequest();
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06008DEF RID: 36335 RVA: 0x00158856 File Offset: 0x00156A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06008DF0 RID: 36336 RVA: 0x00158859 File Offset: 0x00156A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinUnLoadRequest.Descriptor;
			}
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x00158860 File Offset: 0x00156A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadRequest()
		{
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x00158868 File Offset: 0x00156A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadRequest(FlySkinUnLoadRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x00158899 File Offset: 0x00156A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinUnLoadRequest Clone()
		{
			return new FlySkinUnLoadRequest(this);
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06008DF4 RID: 36340 RVA: 0x001588A1 File Offset: 0x00156AA1
		// (set) Token: 0x06008DF5 RID: 36341 RVA: 0x001588A9 File Offset: 0x00156AA9
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

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06008DF6 RID: 36342 RVA: 0x001588B2 File Offset: 0x00156AB2
		// (set) Token: 0x06008DF7 RID: 36343 RVA: 0x001588BA File Offset: 0x00156ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06008DF8 RID: 36344 RVA: 0x001588C3 File Offset: 0x00156AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinUnLoadRequest);
		}

		// Token: 0x06008DF9 RID: 36345 RVA: 0x001588D1 File Offset: 0x00156AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinUnLoadRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DFA RID: 36346 RVA: 0x00158910 File Offset: 0x00156B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DFB RID: 36347 RVA: 0x00158968 File Offset: 0x00156B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008DFC RID: 36348 RVA: 0x00158975 File Offset: 0x00156B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x00158980 File Offset: 0x00156B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkinId);
			}
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

		// Token: 0x06008DFE RID: 36350 RVA: 0x001589DC File Offset: 0x00156BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DFF RID: 36351 RVA: 0x00158A34 File Offset: 0x00156C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinUnLoadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E00 RID: 36352 RVA: 0x00158A84 File Offset: 0x00156C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E01 RID: 36353 RVA: 0x00158A90 File Offset: 0x00156C90
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
				if (num != 64U)
				{
					if (num != 88U)
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
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004595 RID: 17813
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004596 RID: 17814
		public const int RoleIdFieldNumber = 11;

		// Token: 0x04004597 RID: 17815
		private int roleId_;

		// Token: 0x04004598 RID: 17816
		public const int SkinIdFieldNumber = 8;

		// Token: 0x04004599 RID: 17817
		private int skinId_;
	}
}
