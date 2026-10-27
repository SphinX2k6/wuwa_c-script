using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF1 RID: 2801
	public sealed class NearbyTrackingComponentPb : IMessage<NearbyTrackingComponentPb>, IMessage, IEquatable<NearbyTrackingComponentPb>, IDeepCloneable<NearbyTrackingComponentPb>, IBufferMessage
	{
		// Token: 0x0600F38B RID: 62347 RVA: 0x00238D6C File Offset: 0x00236F6C
		[NullableContext(1)]
		public static NearbyTrackingComponentPb Create()
		{
			return new NearbyTrackingComponentPb();
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x0600F38C RID: 62348 RVA: 0x00238D73 File Offset: 0x00236F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x0600F38D RID: 62349 RVA: 0x00238D76 File Offset: 0x00236F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NearbyTrackingComponentPb.Descriptor;
			}
		}

		// Token: 0x0600F38E RID: 62350 RVA: 0x00238D7D File Offset: 0x00236F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NearbyTrackingComponentPb()
		{
		}

		// Token: 0x0600F38F RID: 62351 RVA: 0x00238D85 File Offset: 0x00236F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NearbyTrackingComponentPb(NearbyTrackingComponentPb other) : this()
		{
			this.isEnable_ = other.isEnable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F390 RID: 62352 RVA: 0x00238DAA File Offset: 0x00236FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NearbyTrackingComponentPb Clone()
		{
			return new NearbyTrackingComponentPb(this);
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x0600F391 RID: 62353 RVA: 0x00238DB2 File Offset: 0x00236FB2
		// (set) Token: 0x0600F392 RID: 62354 RVA: 0x00238DBA File Offset: 0x00236FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnable
		{
			get
			{
				return this.isEnable_;
			}
			set
			{
				this.isEnable_ = value;
			}
		}

		// Token: 0x0600F393 RID: 62355 RVA: 0x00238DC3 File Offset: 0x00236FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NearbyTrackingComponentPb);
		}

		// Token: 0x0600F394 RID: 62356 RVA: 0x00238DD1 File Offset: 0x00236FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NearbyTrackingComponentPb other)
		{
			return other != null && (other == this || (this.IsEnable == other.IsEnable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F395 RID: 62357 RVA: 0x00238E00 File Offset: 0x00237000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsEnable)
			{
				num ^= this.IsEnable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F396 RID: 62358 RVA: 0x00238E3F File Offset: 0x0023703F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F397 RID: 62359 RVA: 0x00238E4C File Offset: 0x0023704C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F398 RID: 62360 RVA: 0x00238E55 File Offset: 0x00237055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsEnable)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsEnable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F399 RID: 62361 RVA: 0x00238E88 File Offset: 0x00237088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsEnable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F39A RID: 62362 RVA: 0x00238EBA File Offset: 0x002370BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NearbyTrackingComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsEnable)
			{
				this.IsEnable = other.IsEnable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F39B RID: 62363 RVA: 0x00238EEB File Offset: 0x002370EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F39C RID: 62364 RVA: 0x00238EF4 File Offset: 0x002370F4
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
					this.IsEnable = input.ReadBool();
				}
			}
		}

		// Token: 0x04006227 RID: 25127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006228 RID: 25128
		public const int IsEnableFieldNumber = 1;

		// Token: 0x04006229 RID: 25129
		private bool isEnable_;
	}
}
