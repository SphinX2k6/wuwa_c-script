using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC6 RID: 3782
	[NetMessage(EMessageId.RecoverPropChangedNotify)]
	public sealed class RecoverPropChangedNotify : IMessage<RecoverPropChangedNotify>, IMessage, IEquatable<RecoverPropChangedNotify>, IDeepCloneable<RecoverPropChangedNotify>, IBufferMessage
	{
		// Token: 0x060144D8 RID: 83160 RVA: 0x002F3E30 File Offset: 0x002F2030
		[NullableContext(1)]
		public static RecoverPropChangedNotify Create()
		{
			return new RecoverPropChangedNotify();
		}

		// Token: 0x17004384 RID: 17284
		// (get) Token: 0x060144D9 RID: 83161 RVA: 0x002F3E37 File Offset: 0x002F2037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004385 RID: 17285
		// (get) Token: 0x060144DA RID: 83162 RVA: 0x002F3E3A File Offset: 0x002F203A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecoverPropChangedNotify.Descriptor;
			}
		}

		// Token: 0x060144DB RID: 83163 RVA: 0x002F3E41 File Offset: 0x002F2041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverPropChangedNotify()
		{
		}

		// Token: 0x060144DC RID: 83164 RVA: 0x002F3E54 File Offset: 0x002F2054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverPropChangedNotify(RecoverPropChangedNotify other) : this()
		{
			this.attributes_ = other.attributes_.Clone();
			this.curTime_ = other.curTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060144DD RID: 83165 RVA: 0x002F3E8A File Offset: 0x002F208A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverPropChangedNotify Clone()
		{
			return new RecoverPropChangedNotify(this);
		}

		// Token: 0x17004386 RID: 17286
		// (get) Token: 0x060144DE RID: 83166 RVA: 0x002F3E92 File Offset: 0x002F2092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecoverAttr> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x17004387 RID: 17287
		// (get) Token: 0x060144DF RID: 83167 RVA: 0x002F3E9A File Offset: 0x002F209A
		// (set) Token: 0x060144E0 RID: 83168 RVA: 0x002F3EA2 File Offset: 0x002F20A2
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

		// Token: 0x060144E1 RID: 83169 RVA: 0x002F3EAB File Offset: 0x002F20AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecoverPropChangedNotify);
		}

		// Token: 0x060144E2 RID: 83170 RVA: 0x002F3EBC File Offset: 0x002F20BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecoverPropChangedNotify other)
		{
			return other != null && (other == this || (this.attributes_.Equals(other.attributes_) && this.CurTime == other.CurTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060144E3 RID: 83171 RVA: 0x002F3F0C File Offset: 0x002F210C
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

		// Token: 0x060144E4 RID: 83172 RVA: 0x002F3F59 File Offset: 0x002F2159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060144E5 RID: 83173 RVA: 0x002F3F66 File Offset: 0x002F2166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060144E6 RID: 83174 RVA: 0x002F3F70 File Offset: 0x002F2170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.CurTime);
			}
			this.attributes_.WriteTo(ref output, RecoverPropChangedNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060144E7 RID: 83175 RVA: 0x002F3FC0 File Offset: 0x002F21C0
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

		// Token: 0x060144E8 RID: 83176 RVA: 0x002F4014 File Offset: 0x002F2214
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

		// Token: 0x060144E9 RID: 83177 RVA: 0x002F4061 File Offset: 0x002F2261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060144EA RID: 83178 RVA: 0x002F406C File Offset: 0x002F226C
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
				if (num != 48U)
				{
					if (num != 114U)
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

		// Token: 0x04007BC0 RID: 31680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BC1 RID: 31681
		public const int AttributesFieldNumber = 14;

		// Token: 0x04007BC2 RID: 31682
		private static readonly FieldCodec<RecoverAttr> _repeated_attributes_codec = FieldCodec.ForMessage<RecoverAttr>(114U, RecoverAttr.Parser);

		// Token: 0x04007BC3 RID: 31683
		private readonly RepeatedField<RecoverAttr> attributes_ = new RepeatedField<RecoverAttr>();

		// Token: 0x04007BC4 RID: 31684
		public const int CurTimeFieldNumber = 6;

		// Token: 0x04007BC5 RID: 31685
		private long curTime_;
	}
}
