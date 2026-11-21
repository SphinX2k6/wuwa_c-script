using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001382 RID: 4994
	public sealed class SysBuffComponentPb : IMessage<SysBuffComponentPb>, IMessage, IEquatable<SysBuffComponentPb>, IDeepCloneable<SysBuffComponentPb>, IBufferMessage
	{
		// Token: 0x0601A96B RID: 108907 RVA: 0x003DFA9C File Offset: 0x003DDC9C
		[NullableContext(1)]
		public static SysBuffComponentPb Create()
		{
			return new SysBuffComponentPb();
		}

		// Token: 0x17005A03 RID: 23043
		// (get) Token: 0x0601A96C RID: 108908 RVA: 0x003DFAA3 File Offset: 0x003DDCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A04 RID: 23044
		// (get) Token: 0x0601A96D RID: 108909 RVA: 0x003DFAA6 File Offset: 0x003DDCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SysBuffComponentPb.Descriptor;
			}
		}

		// Token: 0x0601A96E RID: 108910 RVA: 0x003DFAAD File Offset: 0x003DDCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffComponentPb()
		{
		}

		// Token: 0x0601A96F RID: 108911 RVA: 0x003DFAC0 File Offset: 0x003DDCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffComponentPb(SysBuffComponentPb other) : this()
		{
			this.sysBuffInfos_ = other.sysBuffInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A970 RID: 108912 RVA: 0x003DFAEA File Offset: 0x003DDCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffComponentPb Clone()
		{
			return new SysBuffComponentPb(this);
		}

		// Token: 0x17005A05 RID: 23045
		// (get) Token: 0x0601A971 RID: 108913 RVA: 0x003DFAF2 File Offset: 0x003DDCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SysBuffInformation> SysBuffInfos
		{
			get
			{
				return this.sysBuffInfos_;
			}
		}

		// Token: 0x0601A972 RID: 108914 RVA: 0x003DFAFA File Offset: 0x003DDCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SysBuffComponentPb);
		}

		// Token: 0x0601A973 RID: 108915 RVA: 0x003DFB08 File Offset: 0x003DDD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SysBuffComponentPb other)
		{
			return other != null && (other == this || (this.sysBuffInfos_.Equals(other.sysBuffInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A974 RID: 108916 RVA: 0x003DFB3C File Offset: 0x003DDD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.sysBuffInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A975 RID: 108917 RVA: 0x003DFB70 File Offset: 0x003DDD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A976 RID: 108918 RVA: 0x003DFB7D File Offset: 0x003DDD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A977 RID: 108919 RVA: 0x003DFB86 File Offset: 0x003DDD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sysBuffInfos_.WriteTo(ref output, SysBuffComponentPb._repeated_sysBuffInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A978 RID: 108920 RVA: 0x003DFBB0 File Offset: 0x003DDDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sysBuffInfos_.CalculateSize(SysBuffComponentPb._repeated_sysBuffInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A979 RID: 108921 RVA: 0x003DFBE9 File Offset: 0x003DDDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SysBuffComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.sysBuffInfos_.Add(other.sysBuffInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A97A RID: 108922 RVA: 0x003DFC17 File Offset: 0x003DDE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A97B RID: 108923 RVA: 0x003DFC20 File Offset: 0x003DDE20
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
					this.sysBuffInfos_.AddEntriesFrom(ref input, SysBuffComponentPb._repeated_sysBuffInfos_codec);
				}
			}
		}

		// Token: 0x04009BCF RID: 39887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BD0 RID: 39888
		public const int SysBuffInfosFieldNumber = 1;

		// Token: 0x04009BD1 RID: 39889
		private static readonly FieldCodec<SysBuffInformation> _repeated_sysBuffInfos_codec = FieldCodec.ForMessage<SysBuffInformation>(10U, SysBuffInformation.Parser);

		// Token: 0x04009BD2 RID: 39890
		private readonly RepeatedField<SysBuffInformation> sysBuffInfos_ = new RepeatedField<SysBuffInformation>();
	}
}
