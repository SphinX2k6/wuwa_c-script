using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C0 RID: 1984
	public sealed class ICustomScreenSpinePb : IMessage<ICustomScreenSpinePb>, IMessage, IEquatable<ICustomScreenSpinePb>, IDeepCloneable<ICustomScreenSpinePb>, IBufferMessage
	{
		// Token: 0x0600B27B RID: 45691 RVA: 0x001AB4E6 File Offset: 0x001A96E6
		[NullableContext(1)]
		public static ICustomScreenSpinePb Create()
		{
			return new ICustomScreenSpinePb();
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x0600B27C RID: 45692 RVA: 0x001AB4ED File Offset: 0x001A96ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x0600B27D RID: 45693 RVA: 0x001AB4F0 File Offset: 0x001A96F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ICustomScreenSpinePb.Descriptor;
			}
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x001AB4F7 File Offset: 0x001A96F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenSpinePb()
		{
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x001AB4FF File Offset: 0x001A96FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenSpinePb(ICustomScreenSpinePb other) : this()
		{
			this.spineId_ = other.spineId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B280 RID: 45696 RVA: 0x001AB524 File Offset: 0x001A9724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ICustomScreenSpinePb Clone()
		{
			return new ICustomScreenSpinePb(this);
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x0600B281 RID: 45697 RVA: 0x001AB52C File Offset: 0x001A972C
		// (set) Token: 0x0600B282 RID: 45698 RVA: 0x001AB534 File Offset: 0x001A9734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpineId
		{
			get
			{
				return this.spineId_;
			}
			set
			{
				this.spineId_ = value;
			}
		}

		// Token: 0x0600B283 RID: 45699 RVA: 0x001AB53D File Offset: 0x001A973D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ICustomScreenSpinePb);
		}

		// Token: 0x0600B284 RID: 45700 RVA: 0x001AB54B File Offset: 0x001A974B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ICustomScreenSpinePb other)
		{
			return other != null && (other == this || (this.SpineId == other.SpineId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B285 RID: 45701 RVA: 0x001AB57C File Offset: 0x001A977C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SpineId != 0)
			{
				num ^= this.SpineId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B286 RID: 45702 RVA: 0x001AB5BB File Offset: 0x001A97BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B287 RID: 45703 RVA: 0x001AB5C8 File Offset: 0x001A97C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B288 RID: 45704 RVA: 0x001AB5D1 File Offset: 0x001A97D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpineId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SpineId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B289 RID: 45705 RVA: 0x001AB604 File Offset: 0x001A9804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SpineId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpineId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B28A RID: 45706 RVA: 0x001AB642 File Offset: 0x001A9842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ICustomScreenSpinePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SpineId != 0)
			{
				this.SpineId = other.SpineId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B28B RID: 45707 RVA: 0x001AB673 File Offset: 0x001A9873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B28C RID: 45708 RVA: 0x001AB67C File Offset: 0x001A987C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SpineId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004FC3 RID: 20419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FC4 RID: 20420
		public const int SpineIdFieldNumber = 1;

		// Token: 0x04004FC5 RID: 20421
		private int spineId_;
	}
}
