using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D1F RID: 3359
	[NetMessage(EMessageId.PhBaPlanSetPlanStatusRequest)]
	public sealed class PhBaPlanSetPlanStatusRequest : IMessage<PhBaPlanSetPlanStatusRequest>, IMessage, IEquatable<PhBaPlanSetPlanStatusRequest>, IDeepCloneable<PhBaPlanSetPlanStatusRequest>, IBufferMessage
	{
		// Token: 0x06012241 RID: 74305 RVA: 0x002A65E5 File Offset: 0x002A47E5
		[NullableContext(1)]
		public static PhBaPlanSetPlanStatusRequest Create()
		{
			return new PhBaPlanSetPlanStatusRequest();
		}

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x06012242 RID: 74306 RVA: 0x002A65EC File Offset: 0x002A47EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x06012243 RID: 74307 RVA: 0x002A65EF File Offset: 0x002A47EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSetPlanStatusRequest.Descriptor;
			}
		}

		// Token: 0x06012244 RID: 74308 RVA: 0x002A65F6 File Offset: 0x002A47F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusRequest()
		{
		}

		// Token: 0x06012245 RID: 74309 RVA: 0x002A6609 File Offset: 0x002A4809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusRequest(PhBaPlanSetPlanStatusRequest other) : this()
		{
			this.setInfo_ = other.setInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012246 RID: 74310 RVA: 0x002A6633 File Offset: 0x002A4833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetPlanStatusRequest Clone()
		{
			return new PhBaPlanSetPlanStatusRequest(this);
		}

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x06012247 RID: 74311 RVA: 0x002A663B File Offset: 0x002A483B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhBaPlanSetStatusInfo> SetInfo
		{
			get
			{
				return this.setInfo_;
			}
		}

		// Token: 0x06012248 RID: 74312 RVA: 0x002A6643 File Offset: 0x002A4843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSetPlanStatusRequest);
		}

		// Token: 0x06012249 RID: 74313 RVA: 0x002A6651 File Offset: 0x002A4851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSetPlanStatusRequest other)
		{
			return other != null && (other == this || (this.setInfo_.Equals(other.setInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601224A RID: 74314 RVA: 0x002A6684 File Offset: 0x002A4884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.setInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601224B RID: 74315 RVA: 0x002A66B8 File Offset: 0x002A48B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601224C RID: 74316 RVA: 0x002A66C5 File Offset: 0x002A48C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601224D RID: 74317 RVA: 0x002A66CE File Offset: 0x002A48CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.setInfo_.WriteTo(ref output, PhBaPlanSetPlanStatusRequest._repeated_setInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601224E RID: 74318 RVA: 0x002A66F8 File Offset: 0x002A48F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.setInfo_.CalculateSize(PhBaPlanSetPlanStatusRequest._repeated_setInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601224F RID: 74319 RVA: 0x002A6731 File Offset: 0x002A4931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanSetPlanStatusRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.setInfo_.Add(other.setInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012250 RID: 74320 RVA: 0x002A675F File Offset: 0x002A495F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012251 RID: 74321 RVA: 0x002A6768 File Offset: 0x002A4968
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.setInfo_.AddEntriesFrom(ref input, PhBaPlanSetPlanStatusRequest._repeated_setInfo_codec);
				}
			}
		}

		// Token: 0x0400715E RID: 29022
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400715F RID: 29023
		public const int SetInfoFieldNumber = 4;

		// Token: 0x04007160 RID: 29024
		private static readonly FieldCodec<PhBaPlanSetStatusInfo> _repeated_setInfo_codec = FieldCodec.ForMessage<PhBaPlanSetStatusInfo>(34U, PhBaPlanSetStatusInfo.Parser);

		// Token: 0x04007161 RID: 29025
		private readonly RepeatedField<PhBaPlanSetStatusInfo> setInfo_ = new RepeatedField<PhBaPlanSetStatusInfo>();
	}
}
