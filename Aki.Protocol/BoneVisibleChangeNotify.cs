using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BA RID: 442
	[NetMessage(EMessageId.BoneVisibleChangeNotify)]
	public sealed class BoneVisibleChangeNotify : IMessage<BoneVisibleChangeNotify>, IMessage, IEquatable<BoneVisibleChangeNotify>, IDeepCloneable<BoneVisibleChangeNotify>, IBufferMessage
	{
		// Token: 0x06003326 RID: 13094 RVA: 0x000819CD File Offset: 0x0007FBCD
		[NullableContext(1)]
		public static BoneVisibleChangeNotify Create()
		{
			return new BoneVisibleChangeNotify();
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06003327 RID: 13095 RVA: 0x000819D4 File Offset: 0x0007FBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06003328 RID: 13096 RVA: 0x000819D7 File Offset: 0x0007FBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneVisibleChangeNotify.Descriptor;
			}
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x000819DE File Offset: 0x0007FBDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeNotify()
		{
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x000819E6 File Offset: 0x0007FBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeNotify(BoneVisibleChangeNotify other) : this()
		{
			this.boneVisibleData_ = ((other.boneVisibleData_ != null) ? other.boneVisibleData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00081A1B File Offset: 0x0007FC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeNotify Clone()
		{
			return new BoneVisibleChangeNotify(this);
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x00081A23 File Offset: 0x0007FC23
		// (set) Token: 0x0600332D RID: 13101 RVA: 0x00081A2B File Offset: 0x0007FC2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleData BoneVisibleData
		{
			get
			{
				return this.boneVisibleData_;
			}
			set
			{
				this.boneVisibleData_ = value;
			}
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00081A34 File Offset: 0x0007FC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneVisibleChangeNotify);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x00081A42 File Offset: 0x0007FC42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoneVisibleChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.BoneVisibleData, other.BoneVisibleData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x00081A78 File Offset: 0x0007FC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.boneVisibleData_ != null)
			{
				num ^= this.BoneVisibleData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x00081AB4 File Offset: 0x0007FCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x00081AC1 File Offset: 0x0007FCC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00081ACA File Offset: 0x0007FCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.boneVisibleData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.BoneVisibleData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00081AFC File Offset: 0x0007FCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.boneVisibleData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BoneVisibleData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00081B3C File Offset: 0x0007FD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoneVisibleChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.boneVisibleData_ != null)
			{
				if (this.boneVisibleData_ == null)
				{
					this.BoneVisibleData = new BoneVisibleData();
				}
				this.BoneVisibleData.MergeFrom(other.BoneVisibleData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00081B90 File Offset: 0x0007FD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00081B9C File Offset: 0x0007FD9C
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.boneVisibleData_ == null)
					{
						this.BoneVisibleData = new BoneVisibleData();
					}
					input.ReadMessage(this.BoneVisibleData);
				}
			}
		}

		// Token: 0x040029AC RID: 10668
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029AD RID: 10669
		public const int BoneVisibleDataFieldNumber = 6;

		// Token: 0x040029AE RID: 10670
		private BoneVisibleData boneVisibleData_;
	}
}
