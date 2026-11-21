using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001345 RID: 4933
	[NetMessage(EMessageId.SurvivorsOpDataForceChangeNotify)]
	public sealed class SurvivorsOpDataForceChangeNotify : IMessage<SurvivorsOpDataForceChangeNotify>, IMessage, IEquatable<SurvivorsOpDataForceChangeNotify>, IDeepCloneable<SurvivorsOpDataForceChangeNotify>, IBufferMessage
	{
		// Token: 0x0601A4AD RID: 107693 RVA: 0x003D548F File Offset: 0x003D368F
		[NullableContext(1)]
		public static SurvivorsOpDataForceChangeNotify Create()
		{
			return new SurvivorsOpDataForceChangeNotify();
		}

		// Token: 0x1700590E RID: 22798
		// (get) Token: 0x0601A4AE RID: 107694 RVA: 0x003D5496 File Offset: 0x003D3696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700590F RID: 22799
		// (get) Token: 0x0601A4AF RID: 107695 RVA: 0x003D5499 File Offset: 0x003D3699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOpDataForceChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601A4B0 RID: 107696 RVA: 0x003D54A0 File Offset: 0x003D36A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataForceChangeNotify()
		{
		}

		// Token: 0x0601A4B1 RID: 107697 RVA: 0x003D54A8 File Offset: 0x003D36A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataForceChangeNotify(SurvivorsOpDataForceChangeNotify other) : this()
		{
			this.forceIncId_ = other.forceIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A4B2 RID: 107698 RVA: 0x003D54CD File Offset: 0x003D36CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDataForceChangeNotify Clone()
		{
			return new SurvivorsOpDataForceChangeNotify(this);
		}

		// Token: 0x17005910 RID: 22800
		// (get) Token: 0x0601A4B3 RID: 107699 RVA: 0x003D54D5 File Offset: 0x003D36D5
		// (set) Token: 0x0601A4B4 RID: 107700 RVA: 0x003D54DD File Offset: 0x003D36DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ForceIncId
		{
			get
			{
				return this.forceIncId_;
			}
			set
			{
				this.forceIncId_ = value;
			}
		}

		// Token: 0x0601A4B5 RID: 107701 RVA: 0x003D54E6 File Offset: 0x003D36E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOpDataForceChangeNotify);
		}

		// Token: 0x0601A4B6 RID: 107702 RVA: 0x003D54F4 File Offset: 0x003D36F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOpDataForceChangeNotify other)
		{
			return other != null && (other == this || (this.ForceIncId == other.ForceIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A4B7 RID: 107703 RVA: 0x003D5524 File Offset: 0x003D3724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ForceIncId != 0)
			{
				num ^= this.ForceIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A4B8 RID: 107704 RVA: 0x003D5563 File Offset: 0x003D3763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A4B9 RID: 107705 RVA: 0x003D5570 File Offset: 0x003D3770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A4BA RID: 107706 RVA: 0x003D5579 File Offset: 0x003D3779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ForceIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ForceIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A4BB RID: 107707 RVA: 0x003D55AC File Offset: 0x003D37AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ForceIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ForceIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A4BC RID: 107708 RVA: 0x003D55EA File Offset: 0x003D37EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsOpDataForceChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ForceIncId != 0)
			{
				this.ForceIncId = other.ForceIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A4BD RID: 107709 RVA: 0x003D561B File Offset: 0x003D381B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A4BE RID: 107710 RVA: 0x003D5624 File Offset: 0x003D3824
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
					this.ForceIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A8F RID: 39567
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A90 RID: 39568
		public const int ForceIncIdFieldNumber = 1;

		// Token: 0x04009A91 RID: 39569
		private int forceIncId_;
	}
}
