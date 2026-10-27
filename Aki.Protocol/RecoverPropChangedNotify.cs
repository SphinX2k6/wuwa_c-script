using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED6 RID: 3798
	[NetMessage(EMessageId.RecoverPropChangedNotify)]
	public sealed class RecoverPropChangedNotify : IMessage<RecoverPropChangedNotify>, IMessage, IEquatable<RecoverPropChangedNotify>, IDeepCloneable<RecoverPropChangedNotify>, IBufferMessage
	{
		// Token: 0x060145BD RID: 83389 RVA: 0x002F54E4 File Offset: 0x002F36E4
		[NullableContext(1)]
		public static RecoverPropChangedNotify Create()
		{
			return new RecoverPropChangedNotify();
		}

		// Token: 0x170043AE RID: 17326
		// (get) Token: 0x060145BE RID: 83390 RVA: 0x002F54EB File Offset: 0x002F36EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043AF RID: 17327
		// (get) Token: 0x060145BF RID: 83391 RVA: 0x002F54EE File Offset: 0x002F36EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecoverPropChangedNotify.Descriptor;
			}
		}

		// Token: 0x060145C0 RID: 83392 RVA: 0x002F54F5 File Offset: 0x002F36F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverPropChangedNotify()
		{
		}

		// Token: 0x060145C1 RID: 83393 RVA: 0x002F5508 File Offset: 0x002F3708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverPropChangedNotify(RecoverPropChangedNotify other) : this()
		{
			this.attributes_ = other.attributes_.Clone();
			this.curTime_ = other.curTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060145C2 RID: 83394 RVA: 0x002F553E File Offset: 0x002F373E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverPropChangedNotify Clone()
		{
			return new RecoverPropChangedNotify(this);
		}

		// Token: 0x170043B0 RID: 17328
		// (get) Token: 0x060145C3 RID: 83395 RVA: 0x002F5546 File Offset: 0x002F3746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecoverAttr> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x170043B1 RID: 17329
		// (get) Token: 0x060145C4 RID: 83396 RVA: 0x002F554E File Offset: 0x002F374E
		// (set) Token: 0x060145C5 RID: 83397 RVA: 0x002F5556 File Offset: 0x002F3756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurTime
		{
			get
			{
				return this.curTime_;
			}
			set
			{
				this.curTime_ = value;
			}
		}

		// Token: 0x060145C6 RID: 83398 RVA: 0x002F555F File Offset: 0x002F375F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecoverPropChangedNotify);
		}

		// Token: 0x060145C7 RID: 83399 RVA: 0x002F5570 File Offset: 0x002F3770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecoverPropChangedNotify other)
		{
			return other != null && (other == this || (this.attributes_.Equals(other.attributes_) && this.CurTime == other.CurTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060145C8 RID: 83400 RVA: 0x002F55C0 File Offset: 0x002F37C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attributes_.GetHashCode();
			if (this.CurTime != 0L)
			{
				num ^= this.CurTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060145C9 RID: 83401 RVA: 0x002F560D File Offset: 0x002F380D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060145CA RID: 83402 RVA: 0x002F561A File Offset: 0x002F381A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060145CB RID: 83403 RVA: 0x002F5624 File Offset: 0x002F3824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CurTime);
			}
			this.attributes_.WriteTo(ref output, RecoverPropChangedNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060145CC RID: 83404 RVA: 0x002F5674 File Offset: 0x002F3874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributes_.CalculateSize(RecoverPropChangedNotify._repeated_attributes_codec);
			if (this.CurTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060145CD RID: 83405 RVA: 0x002F56C8 File Offset: 0x002F38C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecoverPropChangedNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.attributes_.Add(other.attributes_);
			if (other.CurTime != 0L)
			{
				this.CurTime = other.CurTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060145CE RID: 83406 RVA: 0x002F5715 File Offset: 0x002F3915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060145CF RID: 83407 RVA: 0x002F5720 File Offset: 0x002F3920
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
				if (num != 24U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attributes_.AddEntriesFrom(ref input, RecoverPropChangedNotify._repeated_attributes_codec);
					}
				}
				else
				{
					this.CurTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007B96 RID: 31638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B97 RID: 31639
		public const int AttributesFieldNumber = 6;

		// Token: 0x04007B98 RID: 31640
		private static readonly FieldCodec<RecoverAttr> _repeated_attributes_codec = FieldCodec.ForMessage<RecoverAttr>(50U, RecoverAttr.Parser);

		// Token: 0x04007B99 RID: 31641
		private readonly RepeatedField<RecoverAttr> attributes_ = new RepeatedField<RecoverAttr>();

		// Token: 0x04007B9A RID: 31642
		public const int CurTimeFieldNumber = 3;

		// Token: 0x04007B9B RID: 31643
		private long curTime_;
	}
}
