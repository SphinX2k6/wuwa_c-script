using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B8 RID: 2488
	public sealed class MaterialInfo : IMessage<MaterialInfo>, IMessage, IEquatable<MaterialInfo>, IDeepCloneable<MaterialInfo>, IBufferMessage
	{
		// Token: 0x0600DAAD RID: 55981 RVA: 0x00202420 File Offset: 0x00200620
		[NullableContext(1)]
		public static MaterialInfo Create()
		{
			return new MaterialInfo();
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x0600DAAE RID: 55982 RVA: 0x00202427 File Offset: 0x00200627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x0600DAAF RID: 55983 RVA: 0x0020242A File Offset: 0x0020062A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialInfo.Descriptor;
			}
		}

		// Token: 0x0600DAB0 RID: 55984 RVA: 0x00202431 File Offset: 0x00200631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialInfo()
		{
		}

		// Token: 0x0600DAB1 RID: 55985 RVA: 0x00202444 File Offset: 0x00200644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialInfo(MaterialInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.assetName_ = other.assetName_;
			this.isGroup_ = other.isGroup_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DAB2 RID: 55986 RVA: 0x00202481 File Offset: 0x00200681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialInfo Clone()
		{
			return new MaterialInfo(this);
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x0600DAB3 RID: 55987 RVA: 0x00202489 File Offset: 0x00200689
		// (set) Token: 0x0600DAB4 RID: 55988 RVA: 0x00202491 File Offset: 0x00200691
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

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x0600DAB5 RID: 55989 RVA: 0x0020249A File Offset: 0x0020069A
		// (set) Token: 0x0600DAB6 RID: 55990 RVA: 0x002024A2 File Offset: 0x002006A2
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

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x0600DAB7 RID: 55991 RVA: 0x002024B5 File Offset: 0x002006B5
		// (set) Token: 0x0600DAB8 RID: 55992 RVA: 0x002024BD File Offset: 0x002006BD
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

		// Token: 0x0600DAB9 RID: 55993 RVA: 0x002024C6 File Offset: 0x002006C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialInfo);
		}

		// Token: 0x0600DABA RID: 55994 RVA: 0x002024D4 File Offset: 0x002006D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.AssetName != other.AssetName) && this.IsGroup == other.IsGroup && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DABB RID: 55995 RVA: 0x00202534 File Offset: 0x00200734
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

		// Token: 0x0600DABC RID: 55996 RVA: 0x002025A7 File Offset: 0x002007A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DABD RID: 55997 RVA: 0x002025B4 File Offset: 0x002007B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DABE RID: 55998 RVA: 0x002025C0 File Offset: 0x002007C0
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

		// Token: 0x0600DABF RID: 55999 RVA: 0x0020263C File Offset: 0x0020083C
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

		// Token: 0x0600DAC0 RID: 56000 RVA: 0x002026A4 File Offset: 0x002008A4
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

		// Token: 0x0600DAC1 RID: 56001 RVA: 0x0020270D File Offset: 0x0020090D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DAC2 RID: 56002 RVA: 0x00202718 File Offset: 0x00200918
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

		// Token: 0x04005B33 RID: 23347
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B34 RID: 23348
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04005B35 RID: 23349
		private long entityId_;

		// Token: 0x04005B36 RID: 23350
		public const int AssetNameFieldNumber = 2;

		// Token: 0x04005B37 RID: 23351
		private string assetName_ = "";

		// Token: 0x04005B38 RID: 23352
		public const int IsGroupFieldNumber = 3;

		// Token: 0x04005B39 RID: 23353
		private bool isGroup_;
	}
}
