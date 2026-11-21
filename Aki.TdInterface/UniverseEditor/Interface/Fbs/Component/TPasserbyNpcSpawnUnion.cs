using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062AA RID: 25258
	public class TPasserbyNpcSpawnUnion
	{
		// Token: 0x1700BB88 RID: 48008
		// (get) Token: 0x0602AF3F RID: 175935 RVA: 0x005DC2EA File Offset: 0x005DA4EA
		// (set) Token: 0x0602AF40 RID: 175936 RVA: 0x005DC2F2 File Offset: 0x005DA4F2
		public TPasserbyNpcSpawn Type { get; set; }

		// Token: 0x1700BB89 RID: 48009
		// (get) Token: 0x0602AF41 RID: 175937 RVA: 0x005DC2FB File Offset: 0x005DA4FB
		// (set) Token: 0x0602AF42 RID: 175938 RVA: 0x005DC303 File Offset: 0x005DA503
		public object Value { get; set; }

		// Token: 0x0602AF43 RID: 175939 RVA: 0x005DC30C File Offset: 0x005DA50C
		public TPasserbyNpcSpawnUnion()
		{
			this.Type = TPasserbyNpcSpawn.NONE;
			this.Value = null;
		}

		// Token: 0x0602AF44 RID: 175940 RVA: 0x005DC322 File Offset: 0x005DA522
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AF45 RID: 175941 RVA: 0x005DC334 File Offset: 0x005DA534
		public IPasserbyNpcFixIntervalSpawnT AsIPasserbyNpcFixIntervalSpawn()
		{
			return this.As<IPasserbyNpcFixIntervalSpawnT>();
		}

		// Token: 0x0602AF46 RID: 175942 RVA: 0x005DC33C File Offset: 0x005DA53C
		public static TPasserbyNpcSpawnUnion FromIPasserbyNpcFixIntervalSpawn(IPasserbyNpcFixIntervalSpawnT _ipasserbynpcfixintervalspawn)
		{
			return new TPasserbyNpcSpawnUnion
			{
				Type = TPasserbyNpcSpawn.IPasserbyNpcFixIntervalSpawn,
				Value = _ipasserbynpcfixintervalspawn
			};
		}

		// Token: 0x0602AF47 RID: 175943 RVA: 0x005DC351 File Offset: 0x005DA551
		public IPasserbyNpcOnceOnConditionMetSpawnT AsIPasserbyNpcOnceOnConditionMetSpawn()
		{
			return this.As<IPasserbyNpcOnceOnConditionMetSpawnT>();
		}

		// Token: 0x0602AF48 RID: 175944 RVA: 0x005DC359 File Offset: 0x005DA559
		public static TPasserbyNpcSpawnUnion FromIPasserbyNpcOnceOnConditionMetSpawn(IPasserbyNpcOnceOnConditionMetSpawnT _ipasserbynpconceonconditionmetspawn)
		{
			return new TPasserbyNpcSpawnUnion
			{
				Type = TPasserbyNpcSpawn.IPasserbyNpcOnceOnConditionMetSpawn,
				Value = _ipasserbynpconceonconditionmetspawn
			};
		}

		// Token: 0x0602AF49 RID: 175945 RVA: 0x005DC370 File Offset: 0x005DA570
		public static int Pack(FlatBufferBuilder builder, TPasserbyNpcSpawnUnion _o)
		{
			TPasserbyNpcSpawn type = _o.Type;
			if (type == TPasserbyNpcSpawn.IPasserbyNpcFixIntervalSpawn)
			{
				return IPasserbyNpcFixIntervalSpawn.Pack(builder, _o.AsIPasserbyNpcFixIntervalSpawn()).Value;
			}
			if (type != TPasserbyNpcSpawn.IPasserbyNpcOnceOnConditionMetSpawn)
			{
				return 0;
			}
			return IPasserbyNpcOnceOnConditionMetSpawn.Pack(builder, _o.AsIPasserbyNpcOnceOnConditionMetSpawn()).Value;
		}
	}
}
