using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE0 RID: 2784
	public sealed class NearbyTrackingComponentPb : IMessage<NearbyTrackingComponentPb>, IMessage, IEquatable<NearbyTrackingComponentPb>, IDeepCloneable<NearbyTrackingComponentPb>, IBufferMessage
	{
		// Token: 0x0600F271 RID: 62065 RVA: 0x00236B63 File Offset: 0x00234D63
		[NullableContext(1)]
		public static NearbyTrackingComponentPb Create()
		{
			return new NearbyTrackingComponentPb();
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0600F272 RID: 62066 RVA: 0x00236B6A File Offset: 0x00234D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0600F273 RID: 62067 RVA: 0x00236B6D File Offset: 0x00234D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NearbyTrackingComponentPb.Descriptor;
			}
		}

		// Token: 0x0600F274 RID: 62068 RVA: 0x00236B74 File Offset: 0x00234D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NearbyTrackingComponentPb()
		{
		}

		// Token: 0x0600F275 RID: 62069 RVA: 0x00236B7C File Offset: 0x00234D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NearbyTrackingComponentPb(NearbyTrackingComponentPb other) : this()
		{
			this.isEnable_ = other.isEnable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F276 RID: 62070 RVA: 0x00236BA1 File Offset: 0x00234DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NearbyTrackingComponentPb Clone()
		{
			return new NearbyTrackingComponentPb(this);
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0600F277 RID: 62071 RVA: 0x00236BA9 File Offset: 0x00234DA9
		// (set) Token: 0x0600F278 RID: 62072 RVA: 0x00236BB1 File Offset: 0x00234DB1
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

		// Token: 0x0600F279 RID: 62073 RVA: 0x00236BBA File Offset: 0x00234DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NearbyTrackingComponentPb);
		}

		// Token: 0x0600F27A RID: 62074 RVA: 0x00236BC8 File Offset: 0x00234DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NearbyTrackingComponentPb other)
		{
			return other != null && (other == this || (this.IsEnable == other.IsEnable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F27B RID: 62075 RVA: 0x00236BF8 File Offset: 0x00234DF8
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

		// Token: 0x0600F27C RID: 62076 RVA: 0x00236C37 File Offset: 0x00234E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F27D RID: 62077 RVA: 0x00236C44 File Offset: 0x00234E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F27E RID: 62078 RVA: 0x00236C4D File Offset: 0x00234E4D
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

		// Token: 0x0600F27F RID: 62079 RVA: 0x00236C80 File Offset: 0x00234E80
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

		// Token: 0x0600F280 RID: 62080 RVA: 0x00236CB2 File Offset: 0x00234EB2
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

		// Token: 0x0600F281 RID: 62081 RVA: 0x00236CE3 File Offset: 0x00234EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F282 RID: 62082 RVA: 0x00236CEC File Offset: 0x00234EEC
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

		// Token: 0x04006230 RID: 25136
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006231 RID: 25137
		public const int IsEnableFieldNumber = 1;

		// Token: 0x04006232 RID: 25138
		private bool isEnable_;
	}
}
