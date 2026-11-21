using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CF RID: 4815
	[NetMessage(EMessageId.SolarSchoolTaskUpdateNotify)]
	public sealed class SolarSchoolTaskUpdateNotify : IMessage<SolarSchoolTaskUpdateNotify>, IMessage, IEquatable<SolarSchoolTaskUpdateNotify>, IDeepCloneable<SolarSchoolTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019B3B RID: 105275 RVA: 0x003C00F5 File Offset: 0x003BE2F5
		[NullableContext(1)]
		public static SolarSchoolTaskUpdateNotify Create()
		{
			return new SolarSchoolTaskUpdateNotify();
		}

		// Token: 0x1700570B RID: 22283
		// (get) Token: 0x06019B3C RID: 105276 RVA: 0x003C00FC File Offset: 0x003BE2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700570C RID: 22284
		// (get) Token: 0x06019B3D RID: 105277 RVA: 0x003C00FF File Offset: 0x003BE2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019B3E RID: 105278 RVA: 0x003C0106 File Offset: 0x003BE306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskUpdateNotify()
		{
		}

		// Token: 0x06019B3F RID: 105279 RVA: 0x003C0119 File Offset: 0x003BE319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskUpdateNotify(SolarSchoolTaskUpdateNotify other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B40 RID: 105280 RVA: 0x003C0143 File Offset: 0x003BE343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolTaskUpdateNotify Clone()
		{
			return new SolarSchoolTaskUpdateNotify(this);
		}

		// Token: 0x1700570D RID: 22285
		// (get) Token: 0x06019B41 RID: 105281 RVA: 0x003C014B File Offset: 0x003BE34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolTaskTypePb> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06019B42 RID: 105282 RVA: 0x003C0153 File Offset: 0x003BE353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolTaskUpdateNotify);
		}

		// Token: 0x06019B43 RID: 105283 RVA: 0x003C0161 File Offset: 0x003BE361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B44 RID: 105284 RVA: 0x003C0194 File Offset: 0x003BE394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019B45 RID: 105285 RVA: 0x003C01C8 File Offset: 0x003BE3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B46 RID: 105286 RVA: 0x003C01D5 File Offset: 0x003BE3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B47 RID: 105287 RVA: 0x003C01DE File Offset: 0x003BE3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, SolarSchoolTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B48 RID: 105288 RVA: 0x003C0208 File Offset: 0x003BE408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.task_.CalculateSize(SolarSchoolTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019B49 RID: 105289 RVA: 0x003C0241 File Offset: 0x003BE441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B4A RID: 105290 RVA: 0x003C026F File Offset: 0x003BE46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B4B RID: 105291 RVA: 0x003C0278 File Offset: 0x003BE478
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.task_.AddEntriesFrom(ref input, SolarSchoolTaskUpdateNotify._repeated_task_codec);
				}
			}
		}

		// Token: 0x040097D0 RID: 38864
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097D1 RID: 38865
		public const int TaskFieldNumber = 1;

		// Token: 0x040097D2 RID: 38866
		private static readonly FieldCodec<SolarSchoolTaskTypePb> _repeated_task_codec = FieldCodec.ForMessage<SolarSchoolTaskTypePb>(10U, SolarSchoolTaskTypePb.Parser);

		// Token: 0x040097D3 RID: 38867
		private readonly RepeatedField<SolarSchoolTaskTypePb> task_ = new RepeatedField<SolarSchoolTaskTypePb>();
	}
}
