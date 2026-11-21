using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B76 RID: 2934
	public sealed class OneFishingIllustratedInfo : IMessage<OneFishingIllustratedInfo>, IMessage, IEquatable<OneFishingIllustratedInfo>, IDeepCloneable<OneFishingIllustratedInfo>, IBufferMessage
	{
		// Token: 0x0600FEB6 RID: 65206 RVA: 0x00252F7C File Offset: 0x0025117C
		[NullableContext(1)]
		public static OneFishingIllustratedInfo Create()
		{
			return new OneFishingIllustratedInfo();
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600FEB7 RID: 65207 RVA: 0x00252F83 File Offset: 0x00251183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneFishingIllustratedInfo> Parser
		{
			get
			{
				return OneFishingIllustratedInfo._parser;
			}
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600FEB8 RID: 65208 RVA: 0x00252F8A File Offset: 0x0025118A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600FEB9 RID: 65209 RVA: 0x00252F8D File Offset: 0x0025118D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneFishingIllustratedInfo.Descriptor;
			}
		}

		// Token: 0x0600FEBA RID: 65210 RVA: 0x00252F94 File Offset: 0x00251194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishingIllustratedInfo()
		{
		}

		// Token: 0x0600FEBB RID: 65211 RVA: 0x00252F9C File Offset: 0x0025119C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishingIllustratedInfo(OneFishingIllustratedInfo other) : this()
		{
			this.id_ = other.id_;
			this.maxSize_ = other.maxSize_;
			this.minSize_ = other.minSize_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FEBC RID: 65212 RVA: 0x00252FD9 File Offset: 0x002511D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishingIllustratedInfo Clone()
		{
			return new OneFishingIllustratedInfo(this);
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600FEBD RID: 65213 RVA: 0x00252FE1 File Offset: 0x002511E1
		// (set) Token: 0x0600FEBE RID: 65214 RVA: 0x00252FE9 File Offset: 0x002511E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600FEBF RID: 65215 RVA: 0x00252FF2 File Offset: 0x002511F2
		// (set) Token: 0x0600FEC0 RID: 65216 RVA: 0x00252FFA File Offset: 0x002511FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxSize
		{
			get
			{
				return this.maxSize_;
			}
			set
			{
				this.maxSize_ = value;
			}
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600FEC1 RID: 65217 RVA: 0x00253003 File Offset: 0x00251203
		// (set) Token: 0x0600FEC2 RID: 65218 RVA: 0x0025300B File Offset: 0x0025120B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinSize
		{
			get
			{
				return this.minSize_;
			}
			set
			{
				this.minSize_ = value;
			}
		}

		// Token: 0x0600FEC3 RID: 65219 RVA: 0x00253014 File Offset: 0x00251214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneFishingIllustratedInfo);
		}

		// Token: 0x0600FEC4 RID: 65220 RVA: 0x00253024 File Offset: 0x00251224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneFishingIllustratedInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.MaxSize == other.MaxSize && this.MinSize == other.MinSize && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FEC5 RID: 65221 RVA: 0x00253080 File Offset: 0x00251280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MaxSize != 0)
			{
				num ^= this.MaxSize.GetHashCode();
			}
			if (this.MinSize != 0)
			{
				num ^= this.MinSize.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FEC6 RID: 65222 RVA: 0x002530F1 File Offset: 0x002512F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FEC7 RID: 65223 RVA: 0x002530FE File Offset: 0x002512FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FEC8 RID: 65224 RVA: 0x00253108 File Offset: 0x00251308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.MaxSize != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxSize);
			}
			if (this.MinSize != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MinSize);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FEC9 RID: 65225 RVA: 0x0025317C File Offset: 0x0025137C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.MaxSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxSize);
			}
			if (this.MinSize != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinSize);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FECA RID: 65226 RVA: 0x002531EC File Offset: 0x002513EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneFishingIllustratedInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.MaxSize != 0)
			{
				this.MaxSize = other.MaxSize;
			}
			if (other.MinSize != 0)
			{
				this.MinSize = other.MinSize;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FECB RID: 65227 RVA: 0x00253250 File Offset: 0x00251450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FECC RID: 65228 RVA: 0x0025325C File Offset: 0x0025145C
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MinSize = input.ReadInt32();
						}
					}
					else
					{
						this.MaxSize = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040065F4 RID: 26100
		private static readonly MessageParser<OneFishingIllustratedInfo> _parser = new MessageParser<OneFishingIllustratedInfo>(() => new OneFishingIllustratedInfo());

		// Token: 0x040065F5 RID: 26101
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065F6 RID: 26102
		public const int IdFieldNumber = 1;

		// Token: 0x040065F7 RID: 26103
		private int id_;

		// Token: 0x040065F8 RID: 26104
		public const int MaxSizeFieldNumber = 2;

		// Token: 0x040065F9 RID: 26105
		private int maxSize_;

		// Token: 0x040065FA RID: 26106
		public const int MinSizeFieldNumber = 3;

		// Token: 0x040065FB RID: 26107
		private int minSize_;
	}
}
