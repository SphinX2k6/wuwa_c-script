using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C9 RID: 2505
	public sealed class MaterialInfo : IMessage<MaterialInfo>, IMessage, IEquatable<MaterialInfo>, IDeepCloneable<MaterialInfo>, IBufferMessage
	{
		// Token: 0x0600DBC7 RID: 56263 RVA: 0x00204618 File Offset: 0x00202818
		[NullableContext(1)]
		public static MaterialInfo Create()
		{
			return new MaterialInfo();
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x0600DBC8 RID: 56264 RVA: 0x0020461F File Offset: 0x0020281F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x0600DBC9 RID: 56265 RVA: 0x00204622 File Offset: 0x00202822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialInfo.Descriptor;
			}
		}

		// Token: 0x0600DBCA RID: 56266 RVA: 0x00204629 File Offset: 0x00202829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialInfo()
		{
		}

		// Token: 0x0600DBCB RID: 56267 RVA: 0x0020463C File Offset: 0x0020283C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialInfo(MaterialInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.assetName_ = other.assetName_;
			this.isGroup_ = other.isGroup_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBCC RID: 56268 RVA: 0x00204679 File Offset: 0x00202879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialInfo Clone()
		{
			return new MaterialInfo(this);
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x0600DBCD RID: 56269 RVA: 0x00204681 File Offset: 0x00202881
		// (set) Token: 0x0600DBCE RID: 56270 RVA: 0x00204689 File Offset: 0x00202889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x0600DBCF RID: 56271 RVA: 0x00204692 File Offset: 0x00202892
		// (set) Token: 0x0600DBD0 RID: 56272 RVA: 0x0020469A File Offset: 0x0020289A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AssetName
		{
			get
			{
				return this.assetName_;
			}
			set
			{
				this.assetName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x0600DBD1 RID: 56273 RVA: 0x002046AD File Offset: 0x002028AD
		// (set) Token: 0x0600DBD2 RID: 56274 RVA: 0x002046B5 File Offset: 0x002028B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsGroup
		{
			get
			{
				return this.isGroup_;
			}
			set
			{
				this.isGroup_ = value;
			}
		}

		// Token: 0x0600DBD3 RID: 56275 RVA: 0x002046BE File Offset: 0x002028BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialInfo);
		}

		// Token: 0x0600DBD4 RID: 56276 RVA: 0x002046CC File Offset: 0x002028CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.AssetName != other.AssetName) && this.IsGroup == other.IsGroup && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBD5 RID: 56277 RVA: 0x0020472C File Offset: 0x0020292C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.AssetName.Length != 0)
			{
				num ^= this.AssetName.GetHashCode();
			}
			if (this.IsGroup)
			{
				num ^= this.IsGroup.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DBD6 RID: 56278 RVA: 0x0020479F File Offset: 0x0020299F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DBD7 RID: 56279 RVA: 0x002047AC File Offset: 0x002029AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBD8 RID: 56280 RVA: 0x002047B8 File Offset: 0x002029B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.AssetName.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.AssetName);
			}
			if (this.IsGroup)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsGroup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBD9 RID: 56281 RVA: 0x00204834 File Offset: 0x00202A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.AssetName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AssetName);
			}
			if (this.IsGroup)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DBDA RID: 56282 RVA: 0x0020489C File Offset: 0x00202A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MaterialInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.AssetName.Length != 0)
			{
				this.AssetName = other.AssetName;
			}
			if (other.IsGroup)
			{
				this.IsGroup = other.IsGroup;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DBDB RID: 56283 RVA: 0x00204905 File Offset: 0x00202B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBDC RID: 56284 RVA: 0x00204910 File Offset: 0x00202B10
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsGroup = input.ReadBool();
						}
					}
					else
					{
						this.AssetName = input.ReadString();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005B2A RID: 23338
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B2B RID: 23339
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04005B2C RID: 23340
		private long entityId_;

		// Token: 0x04005B2D RID: 23341
		public const int AssetNameFieldNumber = 2;

		// Token: 0x04005B2E RID: 23342
		private string assetName_ = "";

		// Token: 0x04005B2F RID: 23343
		public const int IsGroupFieldNumber = 3;

		// Token: 0x04005B30 RID: 23344
		private bool isGroup_;
	}
}
