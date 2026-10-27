using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A1 RID: 5025
	[NetMessage(EMessageId.TowerDefenceInstanceInfoUpdateNotify)]
	public sealed class TowerDefenceInstanceInfoUpdateNotify : IMessage<TowerDefenceInstanceInfoUpdateNotify>, IMessage, IEquatable<TowerDefenceInstanceInfoUpdateNotify>, IDeepCloneable<TowerDefenceInstanceInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601AAA2 RID: 109218 RVA: 0x003DE2D2 File Offset: 0x003DC4D2
		[NullableContext(1)]
		public static TowerDefenceInstanceInfoUpdateNotify Create()
		{
			return new TowerDefenceInstanceInfoUpdateNotify();
		}

		// Token: 0x170059EB RID: 23019
		// (get) Token: 0x0601AAA3 RID: 109219 RVA: 0x003DE2D9 File Offset: 0x003DC4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059EC RID: 23020
		// (get) Token: 0x0601AAA4 RID: 109220 RVA: 0x003DE2DC File Offset: 0x003DC4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceInstanceInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601AAA5 RID: 109221 RVA: 0x003DE2E3 File Offset: 0x003DC4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfoUpdateNotify()
		{
		}

		// Token: 0x0601AAA6 RID: 109222 RVA: 0x003DE2F6 File Offset: 0x003DC4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfoUpdateNotify(TowerDefenceInstanceInfoUpdateNotify other) : this()
		{
			this.instanceInfos_ = other.instanceInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AAA7 RID: 109223 RVA: 0x003DE320 File Offset: 0x003DC520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfoUpdateNotify Clone()
		{
			return new TowerDefenceInstanceInfoUpdateNotify(this);
		}

		// Token: 0x170059ED RID: 23021
		// (get) Token: 0x0601AAA8 RID: 109224 RVA: 0x003DE328 File Offset: 0x003DC528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceInstanceInfo> InstanceInfos
		{
			get
			{
				return this.instanceInfos_;
			}
		}

		// Token: 0x0601AAA9 RID: 109225 RVA: 0x003DE330 File Offset: 0x003DC530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceInstanceInfoUpdateNotify);
		}

		// Token: 0x0601AAAA RID: 109226 RVA: 0x003DE33E File Offset: 0x003DC53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceInstanceInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.instanceInfos_.Equals(other.instanceInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AAAB RID: 109227 RVA: 0x003DE374 File Offset: 0x003DC574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.instanceInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AAAC RID: 109228 RVA: 0x003DE3A8 File Offset: 0x003DC5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AAAD RID: 109229 RVA: 0x003DE3B5 File Offset: 0x003DC5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AAAE RID: 109230 RVA: 0x003DE3BE File Offset: 0x003DC5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instanceInfos_.WriteTo(ref output, TowerDefenceInstanceInfoUpdateNotify._repeated_instanceInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AAAF RID: 109231 RVA: 0x003DE3E8 File Offset: 0x003DC5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.instanceInfos_.CalculateSize(TowerDefenceInstanceInfoUpdateNotify._repeated_instanceInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AAB0 RID: 109232 RVA: 0x003DE421 File Offset: 0x003DC621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceInstanceInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.instanceInfos_.Add(other.instanceInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AAB1 RID: 109233 RVA: 0x003DE44F File Offset: 0x003DC64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AAB2 RID: 109234 RVA: 0x003DE458 File Offset: 0x003DC658
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
					this.instanceInfos_.AddEntriesFrom(ref input, TowerDefenceInstanceInfoUpdateNotify._repeated_instanceInfos_codec);
				}
			}
		}

		// Token: 0x04009AEA RID: 39658
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AEB RID: 39659
		public const int InstanceInfosFieldNumber = 4;

		// Token: 0x04009AEC RID: 39660
		private static readonly FieldCodec<TowerDefenceInstanceInfo> _repeated_instanceInfos_codec = FieldCodec.ForMessage<TowerDefenceInstanceInfo>(34U, TowerDefenceInstanceInfo.Parser);

		// Token: 0x04009AED RID: 39661
		private readonly RepeatedField<TowerDefenceInstanceInfo> instanceInfos_ = new RepeatedField<TowerDefenceInstanceInfo>();
	}
}
